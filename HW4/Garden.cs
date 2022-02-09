using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    internal class Garden
    {
        public Plans[] GardenPlans;
        public Garden(double area, Plans[] plans)
        {
            Area = area;
            GardenPlans = plans;
        }

        public double Area { get; set; }
    }
}
