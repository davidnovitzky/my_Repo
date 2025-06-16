TrafficLightState lightState = TrafficLightState.Red;
string timeSecond;
Console.WriteLine("=== Traffic Light Simulator ===");

while (true)
{
    Console.Write($"\nCurrent State: ");
    
    if (lightState == TrafficLightState.Red)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{lightState}");
        Console.ResetColor();
        Console.WriteLine("Stop and wait!");
        for (int i = 5; i > 0; i--)
        {
            timeSecond = (i == 1) ? "second" : "seconds";
            Console.WriteLine($"Waiting {i} {timeSecond}...");
            Thread.Sleep(1000);
        }
        lightState = TrafficLightState.Yellow;
    }
    else if (lightState == TrafficLightState.Yellow)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{lightState}");
        Console.ResetColor();
        Console.WriteLine("Prepare to go.");
        for (int i = 3; i > 0; i--)
        {
            timeSecond = (i == 1) ? "second" : "seconds";
            Console.WriteLine($"Waiting {i} {timeSecond}...");
            Thread.Sleep(1000);
        }
        lightState = TrafficLightState.Green;
    }
    else if (lightState == TrafficLightState.Green)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{lightState}");
        Console.ResetColor();
        Console.WriteLine("Go go go!");
        for (int i = 5; i > 0; i--)
        {
            timeSecond = (i == 1) ? "second" : "seconds";
            Console.WriteLine($"Waiting {i} {timeSecond}...");
            Thread.Sleep(1000);
        }
        Console.WriteLine("Stop!");
        lightState = TrafficLightState.Red;
    }
}
enum TrafficLightState {  Red, Yellow, Green }
