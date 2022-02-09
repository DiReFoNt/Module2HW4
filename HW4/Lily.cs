using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    internal class Lily : Lilies
    {
        public Lily()
        {
            FamilyPlans = "Lilies";
            Perennial = true;
            Color = "White";
            HeightCm = 150;
            NamePlans = "Lily";
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
            Console.WriteLine("Lilies grow well in loose, fertile, well-drained soils");
        }
    }
}
