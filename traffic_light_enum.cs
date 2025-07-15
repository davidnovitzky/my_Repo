TrafficLightState lightState = TrafficLightState.Red;
string timeSecond;
Console.WriteLine("=== Traffic Light Simulator ===");

while (true)
{
    Console.Write($"\nCurrent State: ");

    switch (lightState)
    {
        case TrafficLightState.Red:
            ShowLightState();
            Console.WriteLine("Stop and wait!");
            CountdownTimerInSeconds(5);
            lightState = TrafficLightState.Yellow;
            break;
        case TrafficLightState.Yellow:
            ShowLightState();
            Console.WriteLine("Prepare to go.");
            CountdownTimerInSeconds(3);
            lightState = TrafficLightState.Green;
            break;
        case TrafficLightState.Green:
            ShowLightState();
            Console.WriteLine("Go go go!");
            CountdownTimerInSeconds(5);
            Console.WriteLine("Stop!");
            lightState = TrafficLightState.Red;
            break;
    }
}
void ShowLightState()
{
    if (lightState == TrafficLightState.Red) Console.ForegroundColor = ConsoleColor.Red;
    else if (lightState == TrafficLightState.Yellow) Console.ForegroundColor = ConsoleColor.Yellow;
    else if (lightState == TrafficLightState.Green) Console.ForegroundColor = ConsoleColor.Green;

    Console.WriteLine($"{lightState}");
    Console.ResetColor();
}
void CountdownTimerInSeconds(int seconds)
{
    int cursorTop = Console.CursorTop;

    for (int i = seconds; seconds > 0; seconds--)
    {
        timeSecond = (seconds == 1) ? "second" : "seconds";
        Console.SetCursorPosition(0, cursorTop);
        Console.WriteLine($"Waiting {seconds} {timeSecond}...");
        Thread.Sleep(1000);
    }
}
enum TrafficLightState { Red, Yellow, Green }
