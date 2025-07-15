Console.WriteLine("Fuel Cost Comparison Between Two Routes");

float fuelPrice = GetUserInput("Enter the Fuel Price: ");
float longRoute = GetUserInput("Enter the distance for the longer route (km): ");
float shortRoute = GetUserInput("Enter the distance for the shorter route (km): ");
float longRouteConsumption = GetUserInput("Long route consumption (L/100km): ");
float shortRouteConsumption = GetUserInput("Short route consumption (L/100km): ");

float fuelUsedLongRoute = longRoute / 100.0f * longRouteConsumption;
float fuelUsedShortRoute = shortRoute / 100.0f * shortRouteConsumption;

float costLongRoute = fuelUsedLongRoute * fuelPrice;
float costShortRoute = fuelUsedShortRoute * fuelPrice;

Console.WriteLine($"\nLong route: {longRoute} km, {longRouteConsumption:F1} L/100km, Cost: {costLongRoute:F2}");
Console.WriteLine($"Short route: {shortRoute} km, {shortRouteConsumption:F1} L/100km, Cost: {costShortRoute:F2}");

if (costLongRoute < costShortRoute) Console.WriteLine("The long route is more cost-effective.");
else if (costShortRoute < costLongRoute) Console.WriteLine("\nThe short route is more cost-effective.");
else Console.WriteLine("Both routes cost the same.");

float GetUserInput(string prompt)
{
    Console.Write(prompt);
    return float.Parse(Console.ReadLine());
}
