using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sandess.Utilities;
using AutoItX3Lib;

namespace Sandess.Stage
{
    public class Chest_farm
    {
        AutoItX3 auto = new AutoItX3();
        Pixel_look pixel_look = new Pixel_look();
        Numpad_click numpad_Click = new Numpad_click();

        public void ex_chest_farm()
        {
            auto.WinActivate("[CLASS:UnityWndClass]");
            auto.Opt("MouseCoordMode", 0);
            auto.Opt("PixelCoordMode", 0);

            auto.Sleep(100); // Delay перед началом функции
            auto.Send("{NUMPAD3}"); // Включение Auto Next Teleport

            var hp = auto.PixelGetColor(447, 757);
            int b = 0;
            while (b != 25)
            {
                hp = auto.PixelGetColor(447, 757);
                auto.Sleep(100);
                if (hp == 0x96d722)
                {
                    b++;
                }
                else
                {
                    b = 0;
                }
            }
            auto.Send("{NUMPAD3}"); // Включение Auto Next Tele
            auto.Sleep(100);
            auto.Send("{NUMPAD6}");
            auto.Sleep(100);
        }

    }
}
