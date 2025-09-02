using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OPP1
{
    public class CaTre : LopCa
    {
        private double Movespeed;
        
        public CaTre(double Movespeed, String FishName, double FishWeight, String FishColour, bool FishScale) : base(FishName, FishWeight, FishColour, FishScale)
        {
            this.Movespeed = Movespeed;
        }
        public override void cachboi()
        {
            Console.WriteLine("bo tren mat dat!!!");
        }
        public override void FishInfor()
        {
            base.FishInfor();
            Console.WriteLine("toc do boi {0:0.00}", Movespeed);
            cachboi();
        }
    } 
}
