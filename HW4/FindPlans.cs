using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    internal static class FindPlans
    {
        public static int FindFlower(this Plans[] p)
        {
            int counter = 0;
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] is Flower)
                {
                    ++counter;
                }
            }

            return counter;
        }

        public static int FindTrees(this Plans[] p)
        {
            int counter = 0;
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] is Trees)
                {
                    ++counter;
                }
            }

            return counter;
        }
    }
}
