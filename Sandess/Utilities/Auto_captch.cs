using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoItX3Lib;
namespace Sandess.Utilities
{
    
    public class Auto_captch
    {
        AutoItX3 auto = new AutoItX3();
        int height = 110;
        int width = 190;
        public void CaptchEnter()
        {
            auto.WinActivate("[CLASS:UnityWndClass]");
            auto.Opt("MouseCoordMode", 0);
            auto.Opt("PixelCoordMode", 0);
            var lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
            var kcolor = auto.PixelGetColor(483, 454);//goluboy na knopke
            int SleepDelay = 100;
            while (lcolor == 0xffffff)//poka beliy delaytsya
            {
                auto.WinActivate("[CLASS:UnityWndClass]");
                auto.Opt("PixelCoordMode", 1);
                var posX = auto.WinGetPosX("[CLASS:UnityWndClass]");
                var posY = auto.WinGetPosY("[CLASS:UnityWndClass]");
                double CheackSumm = auto.PixelChecksum(posX + 420, posY + 325, posX + 420 + width, posY + 325 + height, 1);
                auto.WinActivate("[CLASS:UnityWndClass]");
                auto.Sleep(500);
                auto.Opt("PixelCoordMode", 0);
                switch (CheackSumm)
                {
                    case 3507346998:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(550, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 2707024825:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(550, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 1070100235:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(559, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 3470779072:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(539, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 2755587044:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(545, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 26422906:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(587, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 1048834567:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(567, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 1808950892:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(587, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;

                    case 3607559517:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(587, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 3352846269:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(567, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;

                    case 3335216266:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(560, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 495619150:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(577, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 4216324621:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(510, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 32515717:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(560, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 3280799806:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(526, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 1748436255:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(568, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 1291218081:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(548, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet

                        break;
                    case 1153823886:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(572, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 2636217100:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(588, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 3889182466:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(574, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 4070015200:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(570, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 1556780963:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(579, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 3312337668:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(550, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 3837600041:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(537, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 606467210:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(512, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 2028214511:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(593, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 336520440:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(593, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 1577550874:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(551, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 2524672726:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(591, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 1625291787:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(555, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 3117434825:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(535, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 2955819390:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(545, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 3744678401:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(535, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 177800801:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(567, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 3710530276:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(531, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 3989545810:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(526, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 3825709955:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(535, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 895170696:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(535, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 1152319360:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(564, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 435193941:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(564, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 715566737:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(574, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 82187160:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(544, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 2854218511:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(514, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 2606223717:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(514, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 2228850278:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(584, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 1104968965:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(519, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 1709221994:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(534, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 1304326956:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(574, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 1569060396:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(574, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 2987905751:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(569, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 2084687896:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(550, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 2979137831:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(524, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 798367041:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(584, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 2085815009:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(589, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 3774740250:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(513, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 3866475049:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(533, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 965396429:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(524, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 3444601532:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(571, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 1232734494:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(589, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 615442927:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(549, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 3303281421:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(561, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 920880211:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(531, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 3890303540:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(541, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 3750077587:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(521, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 1418112450:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(556, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 1216925502:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseMove(592, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 3531283116:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(577, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 3229218801:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(525, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 1420201186:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(545, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 707046653:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(589, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;


                    case 2274663057:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(531, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;

                    case 1748289274:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(561, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 2124824807:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(545, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 1208177287:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(589, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 1902269074:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(569, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 419098728:
                        auto.MouseMove(440, 460);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.MouseMove(569, 460);
                        auto.MouseUp("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        break;
                    case 21721935://если вылазит синяя ошибка после не точного ввода капчи
                        auto.MouseMove(516, 450);
                        auto.Sleep(SleepDelay);
                        auto.MouseDown("LEFT");
                        auto.Sleep(1500);
                        lcolor = auto.PixelGetColor(400, 490);//beliy poka rabotaet
                        continue;
                    default:
                        auto.Sleep(1000);
                        kcolor = auto.PixelGetColor(483, 454);
                        auto.Opt("PixelCoordMode", 0);
                        auto.MouseMove(456, 508);
                        auto.MouseClick("LEFT");//po perezagruzke kaptchi          
                        auto.Sleep(1000);
                        kcolor = auto.PixelGetColor(483, 454);
                        if (kcolor == 0x8a9dca || kcolor == 0xd7ddec || kcolor == 0xa0b1d9)//esli poyavilas oshibka sinya 
                        {
                            auto.MouseClick("LEFT", 510, 458);//prodoljit
                            auto.Sleep(500);
                            break;
                        }
                        break;
                }
                auto.Sleep(500);
                kcolor = auto.PixelGetColor(483, 454);
                if (kcolor == 0x8a9dca || kcolor == 0xd7ddec || kcolor == 0xa0b1d9)//esli poyavilas oshibka sinya 
                {
                    auto.MouseClick("LEFT", 510, 458);//prodoljit
                    auto.Sleep(500);
                }
                auto.Sleep(1000);
                lcolor = auto.PixelGetColor(400, 490);
            }
            auto.Opt("PixelCoordMode", 0);
        }
    }
}
