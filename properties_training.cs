Car newCar = new Car();
Console.WriteLine(newCar.TopSpeed);
//newCar.TopSpeed = 235f;
Console.WriteLine($"Your car is a {newCar.Make} and it's Top speed is {newCar.TopSpeed}");
newCar.Make = "BMW";
Console.WriteLine($"Your car is a {newCar.Make} and it's Top speed is {newCar.TopSpeed}");
Console.WriteLine($"Cars yer is {newCar.Year}");
newCar.Year = 2005;

public class Car
{
    //public string _make;
    //private readonly int _year;
    //private float _topSpeed;

    //public Car(int year)
    //{
    //    _year = year;
    //}
    public int Year { get; set; }
    public float TopSpeed { get; } = 240f;

    public string Make { get; set; } = "Toyota";

    enum Color { White, Black }
}
