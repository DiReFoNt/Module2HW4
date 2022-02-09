using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    internal class Apple : Seeds
    {
        public Apple()
        {
            FamilyPlans = "Seeds";
            Perennial = true;
            Color = "Green or Red";
            HeightCm = 1000;
            NamePlans = "Apple";
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
            Console.WriteLine("Planting in the fall provides the maximum " +
                "opportunity for young crops to take root, " +
                "but you can also plant apple trees in the spring.");
        }
    }
}
