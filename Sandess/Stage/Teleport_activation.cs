using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sandess.Utilities;
using AutoItX3Lib;


namespace Sandess.Stage
{
    public class Teleport_activation
    {
        AutoItX3 auto = new AutoItX3();
        Pixel_look pixel_look = new Pixel_look();
        Numpad_click numpad_Click = new Numpad_click();

        public void teleport_activation()
        {
            auto.WinActivate("[CLASS:UnityWndClass]");
            auto.Opt("PixelCoordMode", 0);
            auto.Opt("MouseCoordMode", 0);

            auto.Sleep(100);
            auto.Send("{' DOWN}");
            auto.Sleep(100);
            // ↑↑↑ Game speed x20 ↑↑↑

            numpad_Click.numpad_push(7, 300); // x1-x7
            auto.Sleep(100);

            var hp = auto.PixelGetColor(592, 412);
            int b = 0;

            while (b != 30)
            {
                hp = auto.PixelGetColor(592, 412);
                auto.Sleep(15);
                if (hp == 0xFFFFFF)
                {
                    b++;
                }                   
            }
            numpad_Click.triple_f_attack(100);

            // ↓↓↓ Game speed x20 ↓↓↓
            auto.Sleep(100);
            auto.Send("{' UP}");
            auto.Sleep(100);          
        }
    }
}
