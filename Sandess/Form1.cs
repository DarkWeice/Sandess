using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Sandess.Utilities;
using AutoItX3Lib;
using Sandess.Stage;

namespace Sandess
{
    public partial class Form1 : Form
    {
        AutoItX3 auto = new AutoItX3();
        Auto_captch Captch = new Auto_captch();
        Pixel_look pixel_look = new Pixel_look();
        Create_character create_Character = new Create_character();
        int number_str = 0; // Объявление переменной номера строки
        string log;
        string pas;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            auto.Sleep(1000);
            auto.WinActivate("[CLASS:UnityWndClass]");
            auto.Opt("MouseCoordMode", 0);
            auto.Opt("PixelCoordMode", 0);
            try
            {
                int count = File.ReadAllLines("Data/New_accounts.txt").Length; // Считалка строк в тектовом документе
                List<string> lists = new List<string>(); // Выделяет память под лист
                foreach (string Row in File.ReadAllLines("Data/New_accounts.txt"))
                {
                    lists.Add(Row);// Создание листа типа "Массив"
                }
                auto.Opt("PixelCoordMode", 0);
                foreach (string s in lists)
                {
                    auto.Opt("PixelCoordMode", 0);
                    string[] one = s.Split(';'); // Сплитит mail от pass знаком ";"
                    log = one[0 + number_str];
                    pas = one[1 + number_str];
                    auto.Sleep(100);
                    auto.MouseClick("LEFT", 500, 310); // Нажатие на место под логин
                    auto.Sleep(700);
                    auto.Send("^a");
                    auto.Sleep(700);
                    auto.Send(log);
                    auto.Sleep(500);
                    auto.MouseClick("LEFT", 500, 385); // Нажатие на место под пароль
                    auto.Sleep(500);
                    auto.Send("^a");
                    auto.Sleep(500);
                    auto.Send(pas);
                    auto.Sleep(1000);
                    auto.MouseClick("LEFT", 510, 520); // Нажатие на вход
                    auto.Sleep(1000);
                    pixel_look.pixel_look(437, 463, 0x64CC02);
                    Captch.CaptchEnter();
                    var errorcalor = auto.PixelGetColor(351, 418);
                    int qwe = 0;
                    auto.Sleep(500);
                    string path1 = "LosePass.txt";
                    if (qwe != 10)
                    {
                        auto.Sleep(100);
                        errorcalor = auto.PixelGetColor(351, 418);
                        if (errorcalor == 0x333333)
                        {
                            using (StreamWriter stream1 = new StreamWriter(path1, true))
                                stream1.WriteLine(log + ";" + pas);
                            number_str++;
                            continue;
                        }
                        qwe++;
                    }
                    auto.Sleep(5000);
                    var ExitBtnColor = auto.PixelGetColor(973, 742);
                    if (ExitBtnColor == 0x7f7f7f)
                    {
                        auto.Sleep(500);
                        auto.MouseClick("LEFT", 244, 376);
                        auto.Sleep(1000);
                        auto.MouseClick("LEFT", 671, 595);
                        auto.Sleep(1000);
                        auto.Send("{' DOWN}");
                        auto.Sleep(500);
                        auto.MouseClick("LEFT", 520, 290);
                        auto.Sleep(500);
                        pixel_look.pixel_look(973, 742, 0xfefefe);//ждем кнопку выхода
                        auto.Sleep(500);
                        auto.MouseClick("LEFT", 520, 290);
                        auto.Sleep(500);
                        auto.Send("{' UP}");
                    }
                    else
                    {
                        auto.Send("{' DOWN}");
                        auto.Sleep(500);
                        auto.MouseClick("LEFT", 520, 290);
                        auto.Sleep(500);
                        pixel_look.pixel_look(973, 742, 0xfefefe);
                        auto.Sleep(500);
                        auto.MouseClick("LEFT", 520, 290);//ждем кнопку выхода
                        auto.Sleep(500);
                        auto.Send("{' UP}");
                    }

                    //выход из аккаунта

                    string path = "10AR_accounts.txt";
                    using (StreamWriter stream = new StreamWriter(path, true))
                    stream.WriteLine(log + ";" + pas);
                    var tempFile = Path.GetTempFileName();
                    var linesToKeep = File.ReadLines("New_accounts.txt").Where(l => l != log + ";" + pas);
                    File.WriteAllLines(tempFile, linesToKeep);
                    File.Delete("New_accounts.txt");
                    File.Move(tempFile, "New_accounts.txt");
                    auto.Sleep(500);
                    number_str++;
                }
                auto.Sleep(500);
            }
            catch
            {
                MessageBox.Show("Проблемы с чтением данных для входа");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            create_Character.create_character();
        }

        void asd()
        {
            //выход из аккаунта
            auto.Sleep(3000);
            auto.Send("{' DOWN}");
            auto.Sleep(400);
            auto.Send("{ESC}");
            auto.Sleep(700);
            auto.MouseClick("LEFT", 25, 767, 1, 2);
            auto.Sleep(400);
            auto.MouseClick("LEFT", 615, 528, 1, 2);
            auto.Sleep(5000);
            pixel_look.pixel_look(63, 746, 0xFFFFFF);
            auto.Sleep(400);
            auto.MouseClick("LEFT", 972, 745, 1, 2);
            auto.Sleep(400);
            auto.MouseClick("LEFT", 571, 428, 1, 2);
            auto.Sleep(300);
            auto.Send("{' UP}");
            auto.Sleep(2000);
        }
    }
}
