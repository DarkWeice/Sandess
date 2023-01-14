using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sandess.Utilities;
using AutoItX3Lib;

namespace Sandess.Stage
{
    public class Changing_cheat_settings_x
    {
        AutoItX3 auto = new AutoItX3();
        Pixel_look pixel_look = new Pixel_look();

        public void сhanging_cheat_settings_sign_x()
        {
            auto.WinActivate("[CLASS:UnityWndClass]");
            auto.Opt("PixelCoordMode", 0);
            auto.Opt("MouseCoordMode", 0);

            pixel_look.pixel_look(447, 757, 0x96D722); // HEX проверка hp персонажа (Зелёный, не тусклый)
            auto.Sleep(700);
            auto.Send("{F1}"); // Открытие чита для написания буквы "x" в поиске телепортов
            auto.Sleep(100);
            pixel_look.pixel_look(650, 340, 0x182127); // HEX проверка открытого чита на "F1"
            auto.Sleep(100);
            auto.MouseClick("", 155, 672, 1, 2); // Нажатие на "телепорты" в чите
            auto.Sleep(150);
            auto.MouseClick("", 293, 524, 2, 0); // Нажатие + отжатие галочки
            auto.Sleep(100);
            auto.MouseClick("", 371, 524, 5, 0); // Место куда писать букву "x"
            auto.Sleep(100);
            auto.Send("{x}"); // Пишем букву "x"
            auto.Sleep(100);
            auto.MouseClick("", 293, 524, 1, 0); // Нажатие галочки
            auto.Sleep(150);
            auto.MouseClick("", 438, 569, 1, 0); // Нажатие "Select"
            auto.Sleep(100);
            auto.Send("{F1}"); //Закрытие чита для нажатия x1-x7
        }
    }
}
