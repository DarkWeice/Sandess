using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sandess.Utilities;
using AutoItX3Lib;

namespace Sandess.Stage
{
    public class Paimon_escort
    {
        AutoItX3 auto = new AutoItX3();
        Pixel_look pixel_look = new Pixel_look();
        Numpad_click numpad_Click = new Numpad_click();

        public void Paimon_Escort()
        {
            auto.WinActivate("[CLASS:UnityWndClass]");
            auto.Opt("MouseCoordMode", 0);
            auto.Opt("PixelCoordMode", 0);

            auto.Sleep(100);
            auto.Send("{' DOWN}");
            auto.Sleep(100);
            // ↑↑↑ Game speed x20 ↑↑↑

            numpad_Click.numpad_push(25, 500); // x22-x46
            auto.Sleep(2500);
            var cvet = auto.PixelGetColor(447, 757);

            if (cvet == 0x96D722) // HEX проверка по хп появилась ли ошибка при проведении паймон с мыса
            {
                auto.Send("{LCTRL DOWN}");
                auto.Sleep(100);
                auto.Send("{f DOWN}");
                auto.Sleep(300);
                auto.Send("{f UP}");
                auto.Sleep(100);
                auto.Send("{LCTRL UP}");
            }
            else
            {
                auto.Sleep(1000);
            }

            // ↓↓↓ Game speed x20 ↓↓↓
            auto.Sleep(100);
            auto.Send("{' UP}");
            auto.Sleep(700);
        }
    }
}
