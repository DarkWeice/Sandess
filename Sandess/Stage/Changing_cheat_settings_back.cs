using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sandess.Utilities;
using AutoItX3Lib;

namespace Sandess.Stage
{
    public class Changing_cheat_settings_back
    {
        AutoItX3 auto = new AutoItX3();
        Pixel_look pixel_look = new Pixel_look();
        Numpad_click numpad_Click = new Numpad_click();

        public void сhanging_cheat_settings_delete_all()
        {
            auto.WinActivate("[CLASS:UnityWndClass]");
            auto.Opt("MouseCoordMode", 0);
            auto.Opt("PixelCoordMode", 0);

            auto.Send("{F1}");
            auto.Sleep(500);
            auto.MouseClick("", 345, 524, 5, 2);
            auto.Sleep(300);
            auto.Send("{DELETE}");
            auto.Sleep(300);
            auto.MouseClick("", 290, 524, 1, 2);
            auto.Sleep(300);
            auto.Send("{F1}");
        }

    }
}
