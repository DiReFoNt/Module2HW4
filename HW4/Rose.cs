using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    internal class Rose : Rosehip
    {
        public Rose()
        {
            FamilyPlans = "Rosehip";
            Perennial = true;
            Color = "Red";
            HeightCm = 50;
            NamePlans = "Rose";
        }

        public override void Grow()
        {
            if (Perennial == true)
            {
                Console.WriteLine($"I'm growing for many years, my height {HeightCm} cm");
            }
            else
            {
                Console.WriteLine($"I don't live long, my height {HeightCm} cm");
            }
        }

        public override void GrowDetail()
        {
            Console.WriteLine("Cuttings should have a straight cut at the top, " +
                "10 mm above the upper bud, and an oblique cut at the bottom," +
                " 10 mm below the lower bud.");
        }
    }
}
