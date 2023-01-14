using AutoItX3Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandess.Utilities
{
    public class Numpad_click
    {
        AutoItX3 auto = new AutoItX3();
        Pixel_look pixel_look = new Pixel_look();


        public void numpad_push(int num, int delay)
        {
            int teleports = 0;
            while (teleports != num)
            {
                auto.Sleep(delay);
                auto.Send("{NUMPAD5}");
                teleports++;
            }
        }

        public void numpad_out_push(int num, int delay)
        {
            int teleports = 0;
            while (teleports != num)
            {
                auto.Sleep(delay);
                auto.Send("{NUMPAD4}");
                teleports++;
            }
        }

        public void triple_f_attack(int delay)
        {
            int triple_f_attack = 0;
            while (triple_f_attack != 3)
            {
                auto.Send("{f DOWN}");
                auto.Sleep(60);
                auto.Send("{f UP}");
                auto.Sleep(delay);
                triple_f_attack++;
            }
        }
        public void romb_skip()
        {
            pixel_look.pixel_look(389, 400, 0xFFFFFF); // Отслеживание стрелочки на ромбе
            auto.Sleep(1000);
            auto.MouseClick("", 530, 500, 5, 1);
        }      
    }


        


}
