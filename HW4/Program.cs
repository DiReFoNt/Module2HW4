using System;
using System.Linq;
using System.IO;

namespace HW4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Plans[] plans = new Plans[7] { new Rose(), new Apple(), new Pear(), new Lily(), new Violet(), new Currant(), new Raspberry() };
            Garden aska = new Garden(1550, plans);
            Console.WriteLine("Now growing in the garden:");
            for (int i = 0; i < aska.GardenPlans.Length; i++)
            {
                Console.WriteLine(aska.GardenPlans[i].NamePlans);
            }

            Console.WriteLine($"\nThere are {FindPlans.FindFlower(aska.GardenPlans)} flowers " +
    $"and {FindPlans.FindTrees(aska.GardenPlans)} trees in the garden now ");
            Array.Sort(aska.GardenPlans);
            Console.WriteLine("\nSorting by plant height:");
            for (int i = 0; i < aska.GardenPlans.Length; i++)
            {
                Console.WriteLine($"{aska.GardenPlans[i].NamePlans} {aska.GardenPlans[i].HeightCm} cm");
            }

            Console.WriteLine("\nAlso, here are a couple of tips for growing plants:\n");
            Console.WriteLine(aska.GardenPlans[0].NamePlans + ": ");
            aska.GardenPlans[0].GrowDetail();
            Console.WriteLine(aska.GardenPlans[5].NamePlans + ": ");
            aska.GardenPlans[5].GrowDetail();
        }
    }
}