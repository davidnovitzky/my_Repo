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
//Car newCar = new Car() { Make = "Toyota", Year = 2023, TopSpeed = 240f };

//public class Car
//{
//    public string Make { get; set; }
//    public int Year { get; set; }
//    public float TopSpeed { get; set; }
//}

//Car newCar = new Car() { Make = "BMW" }; // with no init; object initializer wont work
//Console.WriteLine(newCar.Make);
//public class Car
//{
//    private int _year;
//    public string Make { get; init; } = "Toyota"; // wit no init; this woud be read only after
//    public int Year => _year = 2023;
//    public float TopSpeed { get; set; }
//}
