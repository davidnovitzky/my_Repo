Car corolla = new Car("Toyota", "Corolla");
Motorcycle ninja = new Motorcycle("Kawasaki", "Ninja");

Vehicle[] vehicles = { corolla, ninja };

foreach (Vehicle vehicle in vehicles)
{
    vehicle.Drive(100);
}

Console.WriteLine();

corolla.Drive(150);

Console.WriteLine();

Console.WriteLine($"The {corolla.Model} has driven {corolla.TotalDistanceDriven}km in total");
Console.WriteLine($"The {ninja.Model} has driven {ninja.TotalDistanceDriven}km in total");

corolla.ResetCurrentDistance();

Console.WriteLine();

Console.WriteLine($"After reset the {corolla.Model} current distance is {corolla.CurrentDistanceDriven}. And a total of {corolla.TotalDistanceDriven}");

public abstract class Vehicle
{
    public string Make { get; }
    public string Model { get; }
    public int TotalDistanceDriven { get; private set; } = 0;
    public int CurrentDistanceDriven { get; private set; } = 0;

    public Vehicle(string make, string model)
    {
        Make = make;
        Model = model;
    }

    public abstract void Drive(int distance);

    protected void UpdateDistance(int distance)
    {
        CurrentDistanceDriven += distance;
        TotalDistanceDriven += distance;
    }
    public void ResetCurrentDistance()
    {
        CurrentDistanceDriven = 0;
    }
}
public class Car : Vehicle
{
    public Car(string make, string model) : base(make, model)
    {
    }
    public override void Drive(int distance)
    {
        Console.WriteLine($"The {Model} is driving for {distance} km");
        UpdateDistance(distance);
    }
}

public class Motorcycle : Vehicle
{
    public Motorcycle(string make, string model) : base(make, model)
    {
    }
    public override void Drive(int distance)
    {
        Console.WriteLine($"The {Model} is riding for {distance} km");
        UpdateDistance(distance);
    }
}
