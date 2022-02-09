using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    internal class Monocots : Flower
    {
        public int NumberSeeds
        {
            get { return 1; }
            protected set { }
        }

        public override void Grow()
        {
            Console.WriteLine("I grow from 1 seed, and I`m Flower");
        }
    }
}
