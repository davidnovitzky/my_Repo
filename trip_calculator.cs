Console.Write($"Distance (km): ");
float distance = float.Parse(Console.ReadLine()); // <- string to float conversion

Console.Write("Fuel Consumption (L/100km): ");
float consumption = float.Parse(Console.ReadLine());

Console.Write("Fuel Price ($): ");
float fuelPrice = float.Parse(Console.ReadLine());

Console.WriteLine("--- Totals ---");

float fuelNeeded = (distance / 100.0f) * consumption;
float fuelCost = fuelNeeded * fuelPrice;

Console.WriteLine($"Total Fuel Needed: {fuelNeeded:F2} liters"); // <- F2  2 decimal points
Console.WriteLine($"Total trip cost: ${fuelCost:F2}");
Console.ReadLine();
