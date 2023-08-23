using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guinea_Pig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double quantityFood = double.Parse(Console.ReadLine()) * 1000;
            double quantityHay = double.Parse(Console.ReadLine()) * 1000;
            double quantityCover = double.Parse(Console.ReadLine()) * 1000;
            double guineaWeight = double.Parse(Console.ReadLine()) * 1000;
            // convert kilogram in gram

            // I found better way
            //double convertQuantityFoodGram = quantityFood * 1000;
            //double convertQuantityHayGram = quantityFood * 1000;
            //double convertQuantityCoverGram = quantityFood * 1000;
            //double convertGuineaWeightGram = quantityFood * 1000;

            for (int days = 1; days <= 30; days++)
            {
                if (quantityCover <= 0 || quantityHay <= 0 || quantityFood <= 0)
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    return;
                }
                quantityFood -= 300;
                if (days % 3 == 0)
                {
                    double quantityCoverRent = (guineaWeight / 3);
                    quantityCover -= quantityCoverRent;
                }

                if (days % 2 == 0)
                {
                    quantityHay -= quantityFood * 0.05;

                }

            }
            Console.WriteLine($"Everything is fine! Puppy is happy! Food: {quantityFood / 1000:F2}, Hay: {quantityHay / 1000:F2}, Cover: {quantityCover / 1000:F2}.");
            //Console.ReadKey();




        }
    }
}
