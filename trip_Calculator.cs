using System;

namespace Trip_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double distance = 0.0; // <- double float variable for decimals
            double consumption = 0.0;
            double fuelPrice = 0.0;
   
            Console.Write($"Distance (km): ");
            distance = float.Parse(Console.ReadLine()); // <- string to float conversion
            
            Console.Write("Fuel Consumption (L/100km): ");
            consumption = float.Parse(Console.ReadLine());

            Console.Write("Fuel Price ($): ");
            fuelPrice = float.Parse(Console.ReadLine());

            Console.WriteLine("--- Totals ---");

            double fuelNeeded = (distance / 100.0) * consumption;
            double fuelCost = fuelNeeded * fuelPrice;

            Console.WriteLine($"Total Fuel Needed: {fuelNeeded:F2} liters"); // <- F2  2 decimal points
            Console.WriteLine($"Total trip cost: ${fuelCost:F2}");
            Console.ReadLine();
        }
    }
}
