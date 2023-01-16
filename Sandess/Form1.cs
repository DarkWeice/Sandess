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
        Changing_cheat_settings_x changing_Cheat_Settings_X = new Changing_cheat_settings_x();
        Teleport_activation teleport_Activation = new Teleport_activation();
        Numpad_click numpad_Click = new Numpad_click();
        Teleport_to_cape teleport_To_Cape = new Teleport_to_cape();
        Paimon_escort paimon_Escort = new Paimon_escort();
        Map_escape map_Escape = new Map_escape();
        Slime_killing slime_Killing = new Slime_killing();
        Venti_cutscene venti_Cutscene = new Venti_cutscene();
        Ember_take ember_Take = new Ember_take();
        Camp_mondshtat camp_Mondshtat = new Camp_mondshtat();
        Dragon_attack dragon_Attack = new Dragon_attack();
        Favonius Favonius = new Favonius();
        Chest_farm chest_Farm = new Chest_farm();
        Mail_katya mail_Katya = new Mail_katya();
        Changing_cheat_settings_back changing_Cheat_Settings_Back = new Changing_cheat_settings_back();
        Exit exit = new Exit();

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
                List<string> lists = new List<string>(); // Выделяет память под лист
                foreach (string Row in File.ReadAllLines(@"..\\..\\Data\\New_accounts.txt"))
                {
                    lists.Add(Row);// Создание листа типа "Массив"
                }
                auto.Opt("PixelCoordMode", 0);
                auto.Sleep(1000);
                foreach (string s in lists)
                {
                    auto.Opt("PixelCoordMode", 0);
                    string[] one = s.Split(';'); // Сплитит mail от pass знаком ";"
                    log = one[0];
                    pas = one[1];
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
                    string path1 = "..\\..\\Data\\LosePass.txt";
                    if (qwe != 10)
                    {
                        auto.Sleep(100);
                        errorcalor = auto.PixelGetColor(351, 418);
                        if (errorcalor == 0x333333)
                        {
                            using (StreamWriter stream1 = new StreamWriter(path1, true))
                                stream1.WriteLine(log + ";" + pas);
                            var tempFile1 = Path.GetTempFileName();
                            var linesToKeep1 = File.ReadLines(@"..\..\Data\New_accounts.txt").Where(l => l != log + ";" + pas);
                            File.WriteAllLines(tempFile1, linesToKeep1);
                            File.Delete(@"..\..\Data\New_accounts.txt");
                            File.Move(tempFile1, @"..\..\Data\New_accounts.txt");
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

                    create_Character.create_character();
                    changing_Cheat_Settings_X.сhanging_cheat_settings_sign_x();
                    teleport_Activation.teleport_activation();
                    numpad_Click.romb_skip();
                    teleport_To_Cape.teleport_To_Cape();
                    paimon_Escort.Paimon_Escort();
                    map_Escape.map_escape();
                    slime_Killing.kill_slime();
                    venti_Cutscene.venti_cutscene();
                    ember_Take.ember_take();
                    camp_Mondshtat.camp_mondshtat();
                    dragon_Attack.dragon_attack();
                    Favonius.favonius_enter();
                    chest_Farm.ex_chest_farm();
                    mail_Katya.Mail_Katya();
                    changing_Cheat_Settings_Back.сhanging_cheat_settings_delete_all();
                    exit.exit();

                    string path = @"..\\..\\Data\\10AR_accounts.txt";
                    using (StreamWriter stream = new StreamWriter(path, true))
                        stream.WriteLine(log + ";" + pas);
                    var tempFile = Path.GetTempFileName();
                    var linesToKeep = File.ReadLines(@"..\\..\\Data\\New_accounts.txt").Where(l => l != log + ";" + pas);
                    File.WriteAllLines(tempFile, linesToKeep);
                    File.Delete(@"..\\..\\Data\\New_accounts.txt");
                    File.Move(tempFile, @"..\\..\\Data\\New_accounts.txt");
                    auto.Sleep(500);
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

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("..\\..\\Data\\New_accounts.txt");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("..\\..\\Data\\10AR_accounts.txt");
        }
    }
}