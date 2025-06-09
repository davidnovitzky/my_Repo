DateTime today = DateTime.Now;

Console.ForegroundColor = ConsoleColor.White;
Console.Write("Today's date is: {0}", today.ToLongDateString());
Console.ReadLine();

PrintSeparatorLine();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("WELCOME TO THE LUCKY NUMBER GAME");
Console.ResetColor();
Console.ReadLine();

string myFirstNameInput;
while (true)
{
    PrintSeparatorLine();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Please enter your name");
    Console.ResetColor();
    Console.Write("Type in your first name: ");
    myFirstNameInput = Console.ReadLine();

    if (!string.IsNullOrEmpty(myFirstNameInput) && myFirstNameInput.All(char.IsLetter))
    {
        break;
    }
}
string myLastNameInput;
while (true)
{
    PrintSeparatorLine();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Please enter your last name");
    Console.ResetColor();
    Console.Write("Type in your last name: ");
    myLastNameInput = Console.ReadLine();

    if (!string.IsNullOrEmpty(myLastNameInput) && myLastNameInput.All(char.IsLetter))
    {
        break;
    }
}

string ageInput;
int parsedAge;

do
{
    PrintSeparatorLine();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("What is your age?");
    Console.ResetColor();
    Console.Write("Type your age: ");

    ageInput = Console.ReadLine();
    int.TryParse(ageInput, out parsedAge);

} while (!int.TryParse(ageInput, out parsedAge));

int minAge = 18;
int yearsUntilMinAge = minAge - parsedAge;

if (parsedAge >= 18)
{
    PrintSeparatorLine();
    Console.Write("You are old enough.");
    Console.Write(" Please press Enter");
    Console.ReadLine();
}

else
{
    PrintSeparatorLine();
    Console.ForegroundColor = ConsoleColor.Red;
    string yearsLabel = (yearsUntilMinAge == 1) ? "year" : "years";
    Console.WriteLine($"Sorry, you must be at least 18. Try again in {yearsUntilMinAge} {yearsLabel}");
    Console.ReadLine();
    return;
}

string lastNameConfirmation;
do
{
    PrintSeparatorLine();
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"Very nice to have you here, {myFirstNameInput}, did you say your last name was, {myLastNameInput}, yes or no?");
    Console.ResetColor();
    PromptUserInput();
    lastNameConfirmation = Console.ReadLine();
} while (lastNameConfirmation.ToLower() != "yes" && lastNameConfirmation.ToLower() != "no");

if (lastNameConfirmation.ToLower() == "yes")
{
    PrintSeparatorLine();
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write($"Oh thats cool! I once knew a {myLastNameInput}, he was a cool dude. Anyway... ");
    Console.ReadLine();
    Console.WriteLine($"Mr. {myLastNameInput}, would you like to play the lucky number game, yes or no?");
    Console.ResetColor();
    PromptAskToPlayGame();
}

else
{
    string confirmedLastName;

    while (true)
    {
        PrintSeparatorLine();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Please enter your last name?");
        Console.ResetColor();
        PromptUserInput();
        confirmedLastName = Console.ReadLine();

        if (!string.IsNullOrEmpty(confirmedLastName) && confirmedLastName.All(char.IsLetter))
        {
            break;
        }
    }

    PrintSeparatorLine();
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"Okay Mr. {confirmedLastName} would you like to play the lucky number game, yes or no?");
    Console.ResetColor();
    PromptAskToPlayGame();
}
void PromptAskToPlayGame()
{
    bool hasPlayed = false;

    Console.Write("Type in your answer: ");
    string replayConfirmation = Console.ReadLine();

    while (replayConfirmation.ToLower() != "no")
    {
        if (replayConfirmation.ToLower() == "yes")
        {
            PlayGame();
            hasPlayed = true;
            break;
        }
        else
        {
            PrintSeparatorLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please enter yes or no");
            Console.ResetColor();
            Console.Write("Type in your answer: ");
            replayConfirmation = Console.ReadLine();
        }
    }

    if (!hasPlayed)
    {
        DisplayGoodByeMessage();
        return;
    }
}
void PlayGame()
{
    while (true)
    {
        PrintSeparatorLine();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Pick a number - 1, 2 or 3");
        Console.ResetColor();
        Console.Write("Type in your answer: ");

        string userAnswerInput = Console.ReadLine();
        string outcomeMessage;

        switch (userAnswerInput)
        {
            case "1":
                PrintSeparatorLine();
                outcomeMessage = "YOU WON THE GAME!";
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(outcomeMessage);
                Console.ReadLine();
                return;

            case "2":
                PrintSeparatorLine();
                outcomeMessage = "You didn't win! Press Enter to continue";
                break;
            case "3":
                PrintSeparatorLine();
                outcomeMessage = "Sorry, better luck next time. Press Enter to continue";
                break;
            default:
                PrintSeparatorLine();
                outcomeMessage = "Sorry, this number doesn't exist. Press Enter to continue";
                break;
        }

        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(outcomeMessage);
        Console.ResetColor();
        Console.ReadLine();

        PrintSeparatorLine();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Would you like to play the game again, yes or no?");
        Console.ResetColor();
        Console.Write("Type in your answer: ");
        string playAgainResponse = Console.ReadLine();
        if (playAgainResponse == "yes") continue; // Skips to the next iteration of the loop
        if (playAgainResponse == "no") break; // Exits this loop entirely

        while (playAgainResponse.ToLower() != "no")
        {
            PrintSeparatorLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please enter yes or no");
            Console.ResetColor();
            Console.Write("Type in your answer: ");
            playAgainResponse = Console.ReadLine();

            if (playAgainResponse == "yes") break; // Exits this loop
        }
        if (playAgainResponse == "no") break; // // Exits this loop entirely
    }

    DisplayGoodByeMessage();
}
void PromptUserInput()
{
    Console.Write("Type in your answer: ");
}
void PrintSeparatorLine()
{
    Console.WriteLine("------------------------------------------------------------------");
}
void DisplayGoodByeMessage()
{
    PrintSeparatorLine();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Alright, maybe next time!");
    Console.ReadLine();
}
