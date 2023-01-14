using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sandess.Utilities;
using AutoItX3Lib;

namespace Sandess.Stage
{
    public class Mail_katya
    {
        AutoItX3 auto = new AutoItX3();
        Pixel_look pixel_look = new Pixel_look();

        public void Mail_Katya()
        {
            auto.WinActivate("[CLASS:UnityWndClass]");
            auto.Opt("MouseCoordMode", 0);
            auto.Opt("PixelCoordMode", 0);

            auto.Send("{NUMPAD8}");
            auto.Sleep(1000);
            pixel_look.pixel_look(592, 412, 0xFFFFFF); // HEX проверка на горящую кнопку "F"
            auto.Sleep(100);
            auto.Send("{f}");
            auto.Sleep(100);
            pixel_look.pixel_look(696, 604, 0xFFFFFF);  // HEX проверка на кнопку "Собрать награды"
            auto.Sleep(250);
            auto.MouseClick("LEFT", 750, 566, 1, 0);
            auto.Sleep(100);
            pixel_look.pixel_look(828, 756, 0xECE5D8);  // HEX проверка на кнопку "Получить"
            auto.Sleep(250);

            auto.MouseClick("LEFT", 828, 756, 1, 0);
            auto.Sleep(250);
            auto.MouseClick("LEFT", 828, 756, 1, 0);
            auto.Sleep(250);
            auto.MouseClick("LEFT", 828, 756, 1, 0);
            auto.Sleep(250);
            auto.MouseClick("LEFT", 828, 756, 1, 0);
            auto.Sleep(250);
            auto.MouseClick("LEFT", 828, 756, 1, 0);
            auto.Sleep(250);

            auto.MouseClick("LEFT", 828, 756, 1, 0);
            auto.Sleep(250);
            auto.MouseClick("LEFT", 828, 756, 1, 0);
            auto.Sleep(250);
            auto.MouseClick("LEFT", 828, 756, 1, 0);
            auto.Sleep(250);
            auto.MouseClick("LEFT", 828, 756, 1, 0);
            auto.Sleep(250);
            auto.MouseClick("LEFT", 828, 756, 1, 0);
            auto.Sleep(250);

            auto.MouseClick("LEFT", 828, 756, 1, 0);
            auto.Sleep(250);
            auto.MouseClick("LEFT", 828, 756, 1, 0);
            auto.Sleep(250);
            auto.MouseClick("LEFT", 828, 756, 1, 0);
            auto.Sleep(250);
            auto.MouseClick("LEFT", 828, 756, 1, 0);
            auto.Sleep(250);
            auto.MouseClick("LEFT", 828, 756, 1, 0);
            auto.Sleep(250);

            auto.MouseClick("LEFT", 828, 756, 1, 0);
            auto.Sleep(250);
            auto.MouseClick("LEFT", 828, 756, 1, 0);
            auto.Sleep(250);
            auto.MouseClick("LEFT", 828, 756, 1, 0);
            auto.Sleep(250);
            auto.MouseClick("LEFT", 828, 756, 1, 0);
            auto.Sleep(250);
            auto.MouseClick("LEFT", 828, 756, 1, 0);
            auto.Sleep(250);

            auto.MouseClick("LEFT", 828, 756, 1, 0);
            auto.Sleep(250);
            auto.MouseClick("LEFT", 828, 756, 1, 0);
            auto.Sleep(250);
            auto.MouseClick("LEFT", 828, 756, 1, 0);
            auto.Sleep(250);
            auto.MouseClick("LEFT", 828, 756, 1, 0);
            auto.Sleep(250);
            auto.MouseClick("LEFT", 828, 756, 1, 0);
            auto.Sleep(250);

            auto.MouseClick("LEFT", 828, 756, 1, 0);
            auto.Sleep(250);
            auto.MouseClick("LEFT", 828, 756, 1, 0);
            auto.Sleep(250);
            auto.MouseClick("LEFT", 828, 756, 1, 0);
            auto.Sleep(250);
            auto.MouseClick("LEFT", 828, 756, 1, 0);
            auto.Sleep(250);
            auto.MouseClick("LEFT", 828, 756, 1, 0);
            auto.Sleep(250);

            auto.MouseClick("LEFT", 828, 756, 1, 0);
            auto.Sleep(250);
            auto.MouseClick("LEFT", 828, 756, 1, 0);
            auto.Sleep(250);
            auto.MouseClick("LEFT", 828, 756, 1, 0);
            auto.Sleep(250);
            auto.MouseClick("LEFT", 828, 756, 1, 0);
            auto.Sleep(250);
            auto.MouseClick("LEFT", 828, 756, 1, 0);
            auto.Sleep(250);

            auto.Sleep(500);                     
            auto.Send("{ESC}");
            auto.Sleep(500);
            auto.Send("{NUMPAD8}");

            
            auto.Sleep(500);
            auto.Send("{' DOWN}");
            auto.Sleep(300);
            // ↑↑↑ Game speed x15 ↑↑↑

            pixel_look.pixel_look(447, 757, 0x96D722); // HEX проверка hp персонажа (Зелёный, не тусклый)
            auto.Sleep(100);
            auto.Send("{ESC}");
            auto.Sleep(100);
            pixel_look.pixel_look(355, 393, 0xECE5D8);
            auto.Sleep(500);
            auto.MouseClick("LEFT", 27, 371, 1, 0);
            auto.Sleep(100);
            pixel_look.pixel_look(81, 761, 0xFFCC33); // Доделать
            auto.Sleep(100);
            auto.MouseClick("LEFT", 135, 765, 1, 0);
            auto.Sleep(500);
            auto.Send("{ESC}");
            auto.Sleep(1000);          
            auto.Send("{ESC}");
            auto.Sleep(1000);

            // ↓↓↓ Game speed x15 ↓↓↓
            auto.Sleep(500);
            auto.Send("{' UP}");
            auto.Sleep(300);

            //var giftmailpix = auto.PixelGetColor(765, 245);
            //auto.Sleep(500);
            //giftmailpix = auto.PixelGetColor(765, 245);
            //if (giftmailpix == 0xae9e80)
            //{
            //    auto.Sleep(200);
            //    auto.MouseClick("LEFT", 765, 245, 1, 5);
            //    auto.Sleep(500);
            //}
        }

    }
}
