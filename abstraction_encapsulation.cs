Car newCar = new Car(2023, Color.White, "Toyota");

// newCar.Speed = 500000; not allowed because the field Speed is private

Console.WriteLine($"You just got a {newCar.GetYear()} {newCar.GetColor()} {newCar.GetMake()}.");
newCar.SetSpeed(234.5f); // Max is 500 (encapsulation)
newCar.Make = "Lamborghini"; // not allowed field is private

class Car // Abstraction - internal logic is hidden from the main program
{
    private float Speed;
    private int Year;
    private Color Color;
    private string Make;

    public int GetYear() => Year;
    public Color GetColor() => Color;
    public string GetMake() => Make;

    public void SetSpeed(float value)
    { 
        if (value > 0f && value <= 500f)
        {
            Console.WriteLine($"And your new max speed is {value} km/h");
            Speed = value;
        }
        else
        {
            Console.WriteLine("Invalid Speed");
        }
    }

    public Car(int year, Color color, string make)
    {
        if (year > 1960 && year <= 2025)
        {
            Year = year;
        }
        else
        {
            Console.WriteLine("Invalid year! Setting default year to 2000.");
            Year = 2000;
        }
        Color = color;
        Make = make;
    }
}
enum Color { White, Black, Red }
