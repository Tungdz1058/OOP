using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LopCa ca_ao = new LopCa();
            CaBayMau cbm = new CaBayMau(3, "Nam", 0.01, "xanh vang do", true);
            cbm.FishInfor();
            Console.WriteLine("  ");
            CaTre ct = new CaTre(1.22, "Tu", 0.2, "den", false);
            ct.FishInfor();
            Console.WriteLine("  ");
            CaChuon cc = new CaChuon(1.56, "Binh", 100, "baysaccauvong", true);
            cc.FishInfor();
        }
    }
}
