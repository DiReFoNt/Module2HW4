using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    internal class Raspberry : Berry
    {
        public Raspberry()
        {
            FamilyPlans = "Berry";
            Perennial = true;
            Color = "Pink";
            HeightCm = 160;
            NamePlans = "Raspberry";
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
            Console.WriteLine("Common raspberry is a deciduous semi-shrub " +
                "that can vary in height from 150 to 250 centimeters.");
        }
    }
}
