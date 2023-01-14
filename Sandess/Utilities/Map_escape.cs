using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sandess.Utilities;
using AutoItX3Lib;


namespace Sandess.Utilities
{
    public class Map_escape
    {
        AutoItX3 auto = new AutoItX3();
        Pixel_look pixel_look = new Pixel_look();

        public void map_escape()
        {
            auto.WinActivate("[CLASS:UnityWndClass]");
            auto.Opt("MouseCoordMode", 0);
            auto.Opt("PixelCoordMode", 0);

            pixel_look.pixel_look(982, 762, 0xECE5D8);
            auto.Sleep(200);
            auto.Send("{ESCAPE}");
            auto.Sleep(200);
            auto.MouseClick("left");
            auto.Sleep(200);
            auto.Send("{ESCAPE}");
        }
    }
}
