using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sandess.Utilities;
using AutoItX3Lib;

namespace Sandess.Stage
{
    public class Exit
    {
        AutoItX3 auto = new AutoItX3();
        Pixel_look pixel_look = new Pixel_look();
        Numpad_click numpad_Click = new Numpad_click();


        public void exit()
        {           
            auto.MouseClick("LEFT", 27, 763, 1, 0);
            auto.Sleep(300);
            auto.MouseClick("LEFT", 630, 526, 1, 0);
            auto.Sleep(3000);
            pixel_look.pixel_look(979, 742, 0x222222);
            auto.Sleep(200);
            auto.MouseClick("LEFT", 979, 742, 1, 0);
            auto.Sleep(200);
            auto.MouseClick("LEFT", 593, 431, 1, 0);
            auto.Sleep(100);
        }

    }
}
