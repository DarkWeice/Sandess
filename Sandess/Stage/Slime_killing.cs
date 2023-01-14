using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sandess.Utilities;
using AutoItX3Lib;

namespace Sandess.Stage
{
     public class Slime_killing
     {
        AutoItX3 auto = new AutoItX3();
        Pixel_look pixel_look = new Pixel_look();
        Numpad_click numpad_Click = new Numpad_click();

        public void kill_slime()
        {
            auto.WinActivate("[CLASS:UnityWndClass]");
            auto.Opt("MouseCoordMode", 0);
            auto.Opt("PixelCoordMode", 0);

            auto.Sleep(4000); // Delay перед началом функции
            pixel_look.pixel_look(447, 757, 0x96D722); // HEX Отслеживание выхода из большой карты персонажа по ХП бару

            auto.Send("{SPACE DOWN}");
            auto.Sleep(1000);
            auto.Send("{SPACE UP}");

            auto.Sleep(500);
            auto.Send("{' DOWN}");
            auto.Sleep(300);
            // ↑↑↑ Game speed x20 ↑↑↑

            auto.Send("{e DOWN}");
            auto.Sleep(500);
            auto.Send("{e UP}");
            auto.Sleep(500);
            auto.Send("{NUMPAD6}"); // Kill aura - ON
            auto.Sleep(1000);
            auto.Send("{NUMPAD6}"); // Kill aura - OFF
            // ↑↑↑ Kill 1st slime ↑↑↑

            auto.Sleep(3000);
            auto.Send("{e DOWN}");
            auto.Sleep(500);
            auto.Send("{e UP}");
            auto.Sleep(500);
            auto.Send("{NUMPAD6}"); // Kill aura - ON
            auto.Sleep(1000);
            auto.Send("{NUMPAD6}"); // Kill aura - OFF
            // ↑↑↑ Kill 2st slime ↑↑↑

            auto.Sleep(3000);
            auto.Send("{q DOWN}");
            auto.Sleep(500);
            auto.Send("{q UP}");
            auto.Sleep(500);
            auto.Send("{NUMPAD6}"); // Kill aura - ON
            // ↑↑↑ Kill 3st slime ↑↑↑

            // ↓↓↓ Game speed x20 ↓↓↓
            auto.Sleep(500);
            auto.Send("{' UP}");
            auto.Sleep(5000);

            auto.Send("{NUMPAD5}"); // Teleport to dragon fly (x47)
            auto.Sleep(1500);
        }

    }
}
