using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    internal class Plans : IComparable, IPlantDetail
    {
        public string FamilyPlans { get; protected set; }
        public string NamePlans { get; protected set; }
        public string Color { get; protected set; }
        public bool Perennial { get; protected set; }
        public double HeightCm { get; protected set; }

        public bool ProcessPhotosynthesis
        {
            get { return true; }
            protected set { }
        }

        public int CompareTo(object? obj)
        {
            Plans p = obj as Plans;
            if (p != null)
            {
                if (HeightCm < p.HeightCm)
                {
                    return -1;
                }
                else if (HeightCm > p.HeightCm)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                throw new Exception("Are these plans for sure?");
            }
        }

        public virtual void Grow()
        {
        }

        public virtual void GrowDetail()
        {
            Console.WriteLine("hahaasdasha");
        }
    }
}
