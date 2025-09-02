using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP1
{
    public class CaBayMau : LopCa
    {
        private int so_mau;
        public CaBayMau(int so_mau, String FishName, double FishWeight, String FishColour, bool FishScale) : base(FishName, FishWeight, FishColour, FishScale)
        {
            this.so_mau = so_mau;
        }

        public override void cachboi()
        {
            Console.WriteLine("boi tung tang tren mat nuoc!!!");
        }
        public override void FishInfor()
        {
            base.FishInfor();
            Console.WriteLine("ca co {0} mau", so_mau);
            cachboi();
        }
    }
}
