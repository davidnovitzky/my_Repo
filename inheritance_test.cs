Car car = new Car
{
    Make = "Toyota",
    Model = "Camry",
    Year = 2022,
    NumberOfDoors = 4
};
Motorcycle motorcycle = new Motorcycle
{
    Make = "Harley-Davidson",
    Model = "Sportster",
    Year = 2021,
    HasSidecar = true
};

Vehicle[] vehicles = { car, motorcycle };

foreach (Vehicle vehicle in vehicles)
{
    if (vehicle.Start())
    {
        vehicle.Drive();
    }
    Console.WriteLine();
}
Console.Write($"Does the {motorcycle.Model} have a sidecar? ");
Console.WriteLine(motorcycle.HasSidecar ? "Yes" : "No");
Console.WriteLine($"How much fuel capacity does the {car.Model} have?");
Console.WriteLine($"{car.FuelCapacity} liters");
Console.WriteLine($"What about the {motorcycle.Make}?");
Console.WriteLine($"{motorcycle.FuelCapacity} liters");

class Vehicle
{
    public string? Make { get; set; }
    public string? Model { get; set; }
    public int Year { get; set; }
    public float FuelCapacity { get; protected set; }
    public float CurrentFuel { get; } = 10;

    public virtual bool Start()
    {
        if (CurrentFuel <= 0)
        {
            Console.WriteLine("Cannot start vehicle: No fuel.");
            return false;
        }
        else
        {
            Console.WriteLine($"Vehicle started");
            return true;
        }
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Make: {Make}\nModel: {Model}\nYear: {Year}\nFuel Capacity: {FuelCapacity}L");
    }
    public virtual void Drive()
    {
        Console.WriteLine("The vehicle is moving...");
    }

}
class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

    public Car()
    {
        FuelCapacity = 50; // Example fuel capacity for a car
    }

    public override bool Start()
    {
        if (CurrentFuel <= 0)
        {
            Console.WriteLine("Cannot start car engine: No fuel.");
            return false;
        }
        else
        {
            Console.WriteLine($"Car engine started");
            return true;
        }
    }
    public override void Drive()
    {
        Console.WriteLine("The car is speeding...");
    }
}
class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }
    public Motorcycle()
    {
        FuelCapacity = 15; // Fixed capacity for simplicity
    }

    public override bool Start()
    {
        if (CurrentFuel <= 0)
        {
            Console.WriteLine("Cannot start motorcycle engine: No fuel.");
            return false;
        }
        else
        {
            Console.WriteLine($"Motorcycle engine roars to life!");
            return true;
        }
    }
    public override void Drive()
    {
        Console.WriteLine("The bike is moving fast!");
    }
}
