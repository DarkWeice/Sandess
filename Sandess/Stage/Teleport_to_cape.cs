using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sandess.Utilities;
using AutoItX3Lib;

namespace Sandess.Stage
{
    public class Teleport_to_cape
    {
        AutoItX3 auto = new AutoItX3();
        Pixel_look pixel_look = new Pixel_look();
        Numpad_click numpad_Click = new Numpad_click();

        public void teleport_To_Cape()
        {
            auto.WinActivate("[CLASS:UnityWndClass]");
            auto.Opt("MouseCoordMode", 0);
            auto.Opt("PixelCoordMode", 0);

            auto.Sleep(100);
            auto.Send("{' DOWN}");
            auto.Sleep(100);
            // ↑↑↑ Game speed x20 ↑↑↑

            numpad_Click.numpad_push(14, 500); // x8-x21

            // ↓↓↓ Game speed x20 ↓↓↓
            auto.Sleep(100);
            auto.Send("{' UP}");
            auto.Sleep(1500);

            var cvet = auto.PixelGetColor(447, 757);

            if (cvet == 0x96D722)
            {
                auto.Send("{NUMPAD4}"); //x20
                auto.Sleep(1500);
                auto.Send("{NUMPAD5}"); //x21       
                auto.Sleep(1500);
            }
            else
            {
                auto.Sleep(100);
            }
            pixel_look.pixel_look(447, 757, 0x96D722);
        }

    }
}
