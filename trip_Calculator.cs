double distance = 0.0;
double consumption = 0.0;
double fuelPrice = 0.0;
   
Console.Write($"Distance (km): ");
distance = float.Parse(Console.ReadLine());
            
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
