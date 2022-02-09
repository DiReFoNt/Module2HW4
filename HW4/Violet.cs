using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    internal class Violet : Violets
    {
        public Violet()
        {
            FamilyPlans = "Violets";
            Perennial = false;
            Color = "Purple";
            HeightCm = 75;
            NamePlans = "Violet";
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
            Console.WriteLine("In a plastic cup pour vermiculite, " +
                "and then carefully planted in it violet cuttings.");
        }
    }
}
