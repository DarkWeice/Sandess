using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoItX3Lib;

namespace Sandess.Utilities
{
    public class Pixel_look
    {
        public void pixel_look(int x, int y, int color)
        {
            AutoItX3 auto = new AutoItX3();

            var iColor = auto.PixelGetColor(x, y);
            while (iColor != color)
            {
                auto.Sleep(25);
                iColor = auto.PixelGetColor(x, y);
            }
        }
    }
}
