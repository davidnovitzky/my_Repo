Console.WriteLine("Fuel Cost Comparison Between Two Routes\n");

Console.Write("Enter fuel price per liter: ");
double fuelPrice = Convert.ToDouble(Console.ReadLine());

Console.Write("\nEnter distance of longer route (km): ");
double longRoute = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter fuel consumption of longer route (liters/100km): ");
double longRouteConsumption = Convert.ToDouble(Console.ReadLine());

Console.Write("\nEnter distance of shorter route (km): ");
double shortRoute = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter fuel consumption of shorter route (liters/100km): ");
double shortRouteConsumption = Convert.ToDouble(Console.ReadLine());

double fuelUsedLongRoute = (longRoute / 100.0) * longRouteConsumption;
double fuelUsedShortRoute= (shortRoute / 100.0) * shortRouteConsumption;

double costLongRoute = fuelUsedLongRoute * fuelPrice;
double costShortRoute = fuelUsedShortRoute * fuelPrice;

Console.WriteLine($"\nLong route: {longRoute} km, {longRouteConsumption:F1} L/100km, Cost: {costLongRoute:F2}");
Console.WriteLine($"Short route: {shortRoute} km, {shortRouteConsumption:F1} L/100km, Cost: {costShortRoute:F2}");

if (costLongRoute < costShortRoute)      Console.WriteLine("The long route is more cost-effective.");
else if (costShortRoute < costLongRoute) Console.WriteLine("\nThe short route is more cost-effective.");
else                                     Console.WriteLine("Both routes cost the same.");
