using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sandess.Utilities;
using AutoItX3Lib;

namespace Sandess.Stage
{
    public class Venti_cutscene
    {
        AutoItX3 auto = new AutoItX3();
        Pixel_look pixel_look = new Pixel_look();
        Numpad_click numpad_Click = new Numpad_click();

        public void venti_cutscene()
        {
            auto.WinActivate("[CLASS:UnityWndClass]");
            auto.Opt("MouseCoordMode", 0);
            auto.Opt("PixelCoordMode", 0);

            pixel_look.pixel_look(447, 757, 0x96D722); // HEX проверка hp персонажа (Зелёный, не тусклый)
            auto.Sleep(700);

            auto.Send("{' DOWN}");
            auto.Sleep(1500);
            // ↑↑↑ Game speed x20 ↑↑↑           
            auto.Send("{NUMPAD5}"); // Движение к Venti (x48)
            // ↓↓↓ Game speed x20 ↓↓↓
            auto.Sleep(100);
            auto.Send("{' UP}");
            auto.Sleep(1000);

            pixel_look.pixel_look(447, 757, 0x96D722); // HEX проверка hp персонажа (Зелёный, не тусклый)
            auto.Sleep(2500); // Для того, чтобы паймон успела дойти до алого кристалла
            auto.Send("{NUMPAD1}"); // Движение в сторону алого кристалла
            auto.Sleep(1000);
            pixel_look.pixel_look(447, 757, 0x96D722); // HEX проверка hp персонажа (Зелёный, не тусклый)
            auto.Sleep(100);
            auto.Send("{NUMPAD8}"); //Отключение NoClip
            auto.Sleep(100);
            auto.Send("{NUMPAD9}"); //Отключение Custom Pickup Range
            auto.Sleep(1500);

            auto.Send("{f DOWN}");
            auto.Sleep(60);
            auto.Send("{f UP}");
            auto.Sleep(1000);

            pixel_look.pixel_look(447, 757, 0x96D722); // HEX проверка hp персонажа (Зелёный, не тусклый)
            auto.Sleep(100);
            auto.Send("{NUMPAD5}");
            auto.Sleep(800);

            auto.Send("{f DOWN}");
            auto.Sleep(60);
            auto.Send("{f UP}");
            auto.Sleep(300);

            auto.Send("{NUMPAD8}"); //Включение NoClip
            auto.Sleep(100);
            auto.Send("{NUMPAD9}"); //Включение Custom Pickup Range
            auto.Sleep(100);

            auto.Send("{NUMPAD1}"); // Движение в сторону появления Эмбер
            auto.Sleep(500);
        }
    }
}
