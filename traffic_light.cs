// if statements

string lightColor = "";
string incomingCars = "";

while (lightColor != "green" || incomingCars != "no")
{
    Console.Write("What is the traffic light color? ");
    lightColor = Console.ReadLine().ToLower().Trim();
    Console.Write("Are there any cars coming? ");
    incomingCars = Console.ReadLine().ToLower().Trim();

    if (lightColor == "green" && incomingCars == "no")
    {
        Console.WriteLine("You can cross the street");
    }
    else if (lightColor == "green" && incomingCars == "yes")
    {
        Console.WriteLine("Wait for the cars to pass!");
    }
    else if (lightColor == "red" && incomingCars == "no")
    {
        Console.WriteLine("Wait for the light to turn green!");
    }
    else
    {
        Console.WriteLine("Do not cross!");
    }
    Console.WriteLine();
}
Console.ReadLine();

// switch expression

string lightColor = "";
string incomingCars = "";

while (lightColor != "green" || incomingCars != "no")
{
    Console.Write("What is the traffic light color? ");
    lightColor = Console.ReadLine().ToLower().Trim();
    Console.Write("Are there any cars coming? ");
    incomingCars = Console.ReadLine().ToLower().Trim();

    string message = (lightColor, incomingCars) switch
    {
        ("green", "no") => "You can cross the street",
        ("green", "yes") => "Wait for the cars to pass!",
        ("red", "no") => "Wait for te light to turn green!",
        _ => "Do not cross!"
    };
    Console.WriteLine(message);
    Console.WriteLine();
}
Console.ReadLine();
