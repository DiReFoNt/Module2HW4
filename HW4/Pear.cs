using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    internal class Pear : Seeds
    {
        public Pear()
        {
            FamilyPlans = "Seeds";
            Perennial = true;
            Color = "Light yellow";
            HeightCm = 1200;
            NamePlans = "Pear";
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
            Console.WriteLine("You can prune a pear tree at any time of year," +
                " but usually when the tree is in bloom " +
                "and then the fruit is ripe on it, it's a shame to cut it. ");
        }
    }
}
