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
            auto.Sleep(100);
            pixel_look.pixel_look(650, 340, 0x182127); // HEX проверка открытого чита на "F1"
            auto.Sleep(100);
            auto.MouseClick("", 371, 524, 5, 0); // Место откуда убирать букву "x"
            auto.Sleep(100);
            auto.Send("{DELETE}");            
            auto.Sleep(100);
            auto.MouseClick("", 293, 524, 2, 0); // Отжатие галочки            
            auto.Sleep(100);
            auto.Send("{F1}");
        }

    }
}
