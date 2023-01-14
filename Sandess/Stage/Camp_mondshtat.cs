using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sandess.Utilities;
using AutoItX3Lib;

namespace Sandess.Stage
{
    public class Camp_mondshtat
    {
        AutoItX3 auto = new AutoItX3();
        Pixel_look pixel_look = new Pixel_look();
        Numpad_click numpad_Click = new Numpad_click();

        public void camp_mondshtat()
        {
            auto.WinActivate("[CLASS:UnityWndClass]");
            auto.Opt("MouseCoordMode", 0);
            auto.Opt("PixelCoordMode", 0);

            auto.Sleep(2500);
            pixel_look.pixel_look(447, 757, 0x96D722); // HEX проверка hp персонажа (Зелёный, не тусклый)
            auto.Sleep(100);           
            auto.Send("{' DOWN}");
            auto.Sleep(2500);
            // ↑↑↑ Game speed x20 ↑↑↑

            auto.Send("{NUMPAD1}"); // Teleport to mondshtat
            auto.Sleep(1000);
            pixel_look.pixel_look(447, 757, 0x4B6B11); // HEX проверка hp персонажа (Тусклый зелёный)
            auto.Sleep(700);
            auto.Send("{j}");
            auto.Sleep(100);
            pixel_look.pixel_look(622, 695, 0x527A7E); // HEX проверка открытой "j"
            auto.Sleep(500);
            auto.MouseClick("", 885, 760, 1, 0);
            auto.Sleep(500);

            auto.Send("{NUMPAD1}"); // Телепорт к Эмбер у статуи архонтов
            auto.Sleep(1000);
            pixel_look.pixel_look(447, 757, 0x96d722); // HEX проверка hp персонажа (Зелёный, не тусклый)
            auto.Sleep(500);

            auto.Send("{NUMPAD1}"); // Телепорт к Эмбер около фонтана
            auto.Sleep(1000);
            pixel_look.pixel_look(447, 757, 0x96d722); // HEX проверка hp персонажа (Зелёный, не тусклый)

            // ↓↓↓ Game speed x20 ↓↓↓
            auto.Sleep(100);
            auto.Send("{' UP}");
            auto.Sleep(100);

            auto.Send("{LSHIFT DOWN}");
            auto.Sleep(1000);
            auto.Send("{LSHIFT UP}");
            auto.Sleep(500);
            auto.Send("{NUMPAD8}"); // no clip выключить         
        }
    }
}
