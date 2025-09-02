using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OPP1
{
    public class CaChuon : LopCa
    {
        private double flyspeed;

        public CaChuon(double flyspeed, String FishName, double FishWeight, String FishColour, bool FishScale) : base(FishName, FishWeight, FishColour, FishScale)
        {
            this.flyspeed = flyspeed;
        }
        public override void cachboi()
        {
            Console.WriteLine("bay tren mat nuoc!!!");
        }
        public override void FishInfor()
        {
            base.FishInfor();
            Console.WriteLine($"toc do boi {flyspeed:0.00} jjj {flyspeed:0.00}");
            cachboi();
        }
    }
}
