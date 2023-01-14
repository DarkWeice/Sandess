using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sandess.Utilities;
using AutoItX3Lib;

namespace Sandess.Stage
{
    public class Ember_take
    {
        AutoItX3 auto = new AutoItX3();
        Pixel_look pixel_look = new Pixel_look();
        Numpad_click numpad_Click = new Numpad_click();

        public void ember_take()
        {
            auto.WinActivate("[CLASS:UnityWndClass]");
            auto.Opt("MouseCoordMode", 0);
            auto.Opt("PixelCoordMode", 0);

            pixel_look.pixel_look(438, 731, 0x000000); // HEX проверка начала катсцены с получением Эмбер
            auto.Sleep(100);
            auto.Send("{' DOWN}");
            auto.Sleep(100);
            // ↑↑↑ Game speed x20 ↑↑↑

            pixel_look.pixel_look(113, 480, 0xFFCC32); // HEX проверка на выпадение Эмбер
            auto.Sleep(700);
            auto.MouseClick("", 288, 539, 10, 0); // Скип уведомления с получение Эмбер
            auto.Sleep(100);         
            pixel_look.pixel_look(447, 757, 0x96D722); // HEX проверка hp персонажа (Зелёный, не тусклый)
            auto.Sleep(300);
            auto.Send("{2}"); // Выбор Эмбер
            auto.Sleep(500);
            auto.Send("{r}"); // Прицеливание за Эмбер в летающего слайма
            auto.Sleep(400);
            auto.Send("{NUMPAD5}"); //x49 (Подгон персонажа вплотную к летающему слайму)
            auto.Sleep(500);
            auto.MouseClick("", 288, 539, 1, 0); // Выстрел в летающего слайма
            auto.Sleep(500);
            auto.MouseClick("", 288, 539, 1, 0); // Выстрел в летающего слайма
            auto.Sleep(200);
            auto.Send("{r}"); // Отмена прицеливание Эмбер
            auto.Sleep(100);
            auto.Send("{NUMPAD1}"); // Движение в сторону лагеря хилличурлов

            // ↓↓↓ Game speed x20 ↓↓↓
            auto.Sleep(100);
            auto.Send("{' UP}");
            auto.Sleep(100);
        }
    }
}
