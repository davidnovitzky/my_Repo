Car car = new Car();
Bicycle bicycle = new Bicycle();
Boat boat = new Boat();

Vehicle[] vehicles = { car, bicycle, boat };

//foreach (Vehicle vehicle in vehicles)
//{
//    vehicle.Go();
//}

for (int i = 0; i < vehicles.Length; i++)
{
    vehicles[i].Go();
}

class Vehicle
{
    public virtual void Go()
    {

    }
}
class Car : Vehicle
{
    public override void Go()
    {
        Console.WriteLine("The car is going.");
    }
}
class Bicycle : Vehicle
{
    public override void Go()
    {
        Console.WriteLine("The bicycle is going.");
    }
}
class Boat : Vehicle
{
    public override void Go()
    {
        Console.WriteLine("The boat is going.");
    }
}   
