using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoItX3Lib;
using Sandess.Utilities;

namespace Sandess.Stage
{
    public class Create_character
    {
        AutoItX3 auto = new AutoItX3();
        Pixel_look pixel_look = new Pixel_look();

        public void create_character()
        {
            auto.WinActivate("[CLASS:UnityWndClass]");
            auto.Opt("PixelCoordMode", 0);
            auto.Opt("MouseCoordMode", 0);
            // ↑↑↑ Default ↑↑↑

            auto.Sleep(500);
            auto.Send("{' DOWN}");
            auto.Sleep(300);
            // ↑↑↑ Game speed x20 ↑↑↑

            pixel_look.pixel_look(874, 320, 0x1D1516); // HEX проверка штанов Итера
            auto.Sleep(100);
            auto.MouseClick("", 833, 761, 1, 0); // Выбор персонажа "Итер"
            auto.Sleep(100);
            pixel_look.pixel_look(584, 747, 0xF5F2EE);  // HEX проверка на месте ввода никнейма персонажа
            auto.Sleep(100);
            auto.MouseClick("", 584, 747, 1, 0); // Выбор персонажа "Итер"
            auto.Sleep(100);
            auto.Send("Kirito"); // Написание никнейма
            auto.Sleep(100);
            auto.MouseClick("", 920, 740, 1, 0); // Нажатие на "Подтвердить"
            auto.Sleep(500);

            // ↓↓↓ Game speed x20 ↓↓↓
            auto.Sleep(500);
            auto.Send("{' UP}");
            auto.Sleep(300);
        }
    }
}
