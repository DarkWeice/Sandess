using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sandess.Utilities;
using AutoItX3Lib;

namespace Sandess.Stage
{
    public class Favonius
    {
        AutoItX3 auto = new AutoItX3();
        Pixel_look pixel_look = new Pixel_look();
        Numpad_click numpad_Click = new Numpad_click();

        public void favonius_enter()
        {
            auto.WinActivate("[CLASS:UnityWndClass]");
            auto.Opt("MouseCoordMode", 0);
            auto.Opt("PixelCoordMode", 0);

            auto.Sleep(500);
            auto.Send("{' DOWN}");
            auto.Sleep(300);
            // ↑↑↑ Game speed x20 ↑↑↑

            pixel_look.pixel_look(447, 757, 0x96D722); // HEX Отслеживание hp после выхода из битвы с драконом
            auto.Sleep(100);
            auto.Send("{NUMPAD9}");
            auto.Sleep(300);
            auto.Send("{NUMPAD1}");
            auto.Sleep(1000);
            pixel_look.pixel_look(447, 757, 0x96D722); // HEX Отслеживание hp после выхода из битвы с драконом
            auto.Sleep(1200);
            numpad_Click.triple_f_attack(200);

            auto.Sleep(2000);
            pixel_look.pixel_look(447, 757, 0x96D722); // HEX Отслеживание hp после входа в Favonius
            auto.Sleep(100);
            auto.Send("{NUMPAD5}"); // x50
            auto.Sleep(1200);
            numpad_Click.triple_f_attack(200);
            auto.Sleep(1000);
            pixel_look.pixel_look(447, 757, 0x96D722); // HEX Отслеживание hp после выхода в Favonius
            auto.Sleep(100);
            auto.Send("{NUMPAD9}"); // ON
            auto.Sleep(100);
            auto.Send("{NUMPAD8}"); // ON
            auto.Sleep(100);

            // ↓↓↓ Game speed x20 ↓↓↓
            auto.Sleep(100);
            auto.Send("{' UP}");
            auto.Sleep(100);
        }

    }
}
