using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    internal class Currant : Berry
    {
        public Currant()
        {
            FamilyPlans = "Berry";
            Perennial = true;
            Color = "Black";
            HeightCm = 100;
            NamePlans = "Currant";
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
            Console.WriteLine("Currants can be propagated vegetatively -" +
                " by arch-shaped birch twigs, woody or green cuttings, " +
                "rooting two-year-old branches from the shrub.");
        }
    }
}
