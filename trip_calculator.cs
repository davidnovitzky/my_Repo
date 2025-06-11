Console.Write($"Distance (km): ");
double distance = float.Parse(Console.ReadLine()); // <- string to float conversion

Console.Write("Fuel Consumption (L/100km): ");
double consumption = float.Parse(Console.ReadLine());

Console.Write("Fuel Price ($): ");
double fuelPrice = float.Parse(Console.ReadLine());

Console.WriteLine("--- Totals ---");

double fuelNeeded = (distance / 100.0) * consumption;
double fuelCost = fuelNeeded * fuelPrice;

Console.WriteLine($"Total Fuel Needed: {fuelNeeded:F2} liters"); // <- F2  2 decimal points
Console.WriteLine($"Total trip cost: ${fuelCost:F2}");
Console.ReadLine();
