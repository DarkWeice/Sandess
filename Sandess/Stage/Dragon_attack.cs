using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sandess.Utilities;
using AutoItX3Lib;


namespace Sandess.Stage
{
    public class Dragon_attack
    {
        AutoItX3 auto = new AutoItX3();
        Pixel_look pixel_look = new Pixel_look();
        Numpad_click numpad_Click = new Numpad_click();

        public void dragon_attack()
        {
            auto.WinActivate("[CLASS:UnityWndClass]");
            auto.Opt("MouseCoordMode", 0);
            auto.Opt("PixelCoordMode", 0);

            auto.Sleep(4000); // Delay перед началом функции
            pixel_look.pixel_look(447, 757, 0x96d722); // HEX проверка hp персонажа (Зелёный, не тусклый)

            auto.Sleep(500);
            auto.Send("{' DOWN}");
            auto.Sleep(500);
            // ↑↑↑ Game speed x20 ↑↑↑

            var aColor = auto.PixelGetColor(980, 768);
            while (aColor == 0xFFE92C)
            {
                auto.MouseDown("LEFT");
                auto.Sleep(5000);
                auto.MouseUp("LEFT");
                auto.Sleep(50);
                aColor = auto.PixelGetColor(980, 768);
            }

            // ↓↓↓ Game speed x20 ↓↓↓
            auto.Sleep(500);
            auto.Send("{' UP}");
            auto.Sleep(3000);
        }

    }
}
