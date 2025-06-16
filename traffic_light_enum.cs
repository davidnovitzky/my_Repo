TrafficLightState lightState = TrafficLightState.Red;
string timeSecond;
Console.WriteLine("=== Traffic Light Simulator ===");

while (true)
{
    Console.Write($"\nCurrent State: ");

    switch (lightState)
    {
        case TrafficLightState.Red:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{lightState}");
            Console.ResetColor();
            Console.WriteLine("Stop and wait!");
            CountdownTimer(5);
            lightState = TrafficLightState.Yellow;
            break;
        case TrafficLightState.Yellow:
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{lightState}");
            Console.ResetColor();
            Console.WriteLine("Prepare to go.");
            CountdownTimer(3);
            lightState = TrafficLightState.Green;
            break;
        case TrafficLightState.Green:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{lightState}");
            Console.ResetColor();
            Console.WriteLine("Go go go!");
            CountdownTimer(5);
            Console.WriteLine("Stop!");
            lightState = TrafficLightState.Red;
            break;
    }
}
void CountdownTimer(int seconds)
{
    for (int i = seconds; seconds > 0; seconds--)
    {
        timeSecond = (seconds == 1) ? "second" : "seconds";
        Console.WriteLine($"Waiting {seconds} {timeSecond}...");
        Thread.Sleep(1000);
    }
}
enum TrafficLightState {  Red, Yellow, Green }
