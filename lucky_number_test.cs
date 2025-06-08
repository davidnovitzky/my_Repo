bool hasPlayed = false;

Console.WriteLine("Would you like to play the lucky number game?");
Console.Write("Type in your answer: ");
string gameAnswer = Console.ReadLine();

while (gameAnswer.ToLower() != "no")
{
    if (gameAnswer.ToLower() == "yes")
    {
        PlayGame();
        hasPlayed = true;
        break;
    }
    else
    {
        Console.WriteLine("-----------------------------");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Please enter yes or no");
        Console.ResetColor();
        Console.Write("Type in your answer: ");
        gameAnswer = Console.ReadLine();
    }
}

if (!hasPlayed)
{
    Console.WriteLine("-----------------------------");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Alright, maybe next time!");
    Console.ReadLine();
    return;
}


void PlayGame()
{
    
    while (gameAnswer.ToLower() == "yes")
    {
        Console.WriteLine("-----------------------------");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Pick a number - 1, 2 or 3");
        Console.ResetColor();
        Console.Write("Type in your answer: ");

        string userValue = Console.ReadLine();
        string message;

        switch (userValue)
        {
            case "1":
                Console.WriteLine("-----------------------------");
                message = "YOU WON THE GAME!";
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(message);
                Console.ReadLine();
                return;

            case "2":
                Console.WriteLine("-----------------------------");
                message = "You didn't win! Press Enter to continue";
                break;
            case "3":
                Console.WriteLine("-----------------------------");
                message = "Sorry, better luck next time. Press Enter to continue";
                break;
            default:
                Console.WriteLine("-----------------------------");
                message = "Sorry, this number doesn't exist. Press Enter to continue";
                break;
        }

        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(message);
        Console.ResetColor();
        Console.ReadLine();

        Console.WriteLine("-----------------------------"); ;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Would you like to play the game again, yes or no?");
        Console.ResetColor();
        Console.Write("Type in your answer: ");
        gameAnswer = Console.ReadLine();
        if (gameAnswer == "yes") continue;

        while (gameAnswer.ToLower() != "no")
        {
            Console.WriteLine("-----------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please enter yes or no");
            Console.ResetColor();
            Console.Write("Type in your answer: ");
            gameAnswer = Console.ReadLine();

            if (gameAnswer == "yes" || gameAnswer == "no") break;
        }
    }

    Console.WriteLine("-----------------------------");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Alright, maybe next time!");
    Console.ReadLine();
}
