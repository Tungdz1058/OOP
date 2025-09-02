using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP1
{
    public abstract class LopCa
    {
            protected String FishName;
            private double FishWeight;
            private String FishColour;
            private bool FishScale;
        public LopCa(String FishName, double FishWeight, String FishColour, bool FishScale)
        {
            this.FishName = FishName;
            this.FishWeight = FishWeight;
            this.FishColour = FishColour;
            this.FishScale = FishScale;
        }
        public virtual void FishInfor()
        {
            Console.WriteLine("Ten ca {0}", FishName);
            Console.WriteLine("Can nang ca {0:0.00}", FishWeight);
            Console.WriteLine("Mau ca {0}", FishColour);
            Console.WriteLine("Ca {0} ",(FishScale ? "co vay" : "da tron"));
        }
        public abstract void cachboi();
    }
}
