DateTime today = DateTime.Now;

Console.ForegroundColor = ConsoleColor.White;
Console.Write("Today's date is: {0}", today.ToLongDateString());
Console.ReadLine();

Dashes();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("WELCOME TO THE LUCKY NUMBER GAME");
Console.ResetColor();
Console.ReadLine();

string myFirstName = "";
while (myFirstName == "")
{
    Dashes();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Please enter your name");
    Console.ResetColor();
    Console.Write("Type in your first name: ");
    myFirstName = Console.ReadLine();
}
string myLastName = "";
do
{
    Dashes();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Please enter your last name");
    Console.ResetColor();
    Console.Write("Type in your last name: ");
    myLastName = Console.ReadLine();
} while (myLastName == "");

string myAge;
int age;

do
{
    Dashes();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("What is your age?");
    Console.ResetColor();
    Console.Write("Type your age: ");

    myAge = Console.ReadLine();
    int.TryParse(myAge, out age);

} while (int.TryParse(myAge, out age) == false);

int minAge = 18;
int yearsLeft = minAge - age;

if (age >= 18)
{
    Dashes();
    Console.Write("You are old enough.");
    Console.Write(" Please press Enter");
    Console.ReadLine();
}

else
{
    Dashes();
    Console.ForegroundColor = ConsoleColor.Red;
    string displayYears = (yearsLeft == 1) ? "year" : "years";
    Console.WriteLine($"Sorry, you must be at least 18. Try again in {yearsLeft} {displayYears}");
    Console.ReadLine();
    return;
}

string lastNameValue = "";
do
{
    Dashes();
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"Very nice to have you here, {myFirstName}, did you say your last name was, {myLastName}, yes or no?");
    Console.ResetColor();
    TypeAnswer();
    lastNameValue = Console.ReadLine();
} while (lastNameValue.ToLower() != "yes" && lastNameValue.ToLower() != "no");

if (lastNameValue.ToLower() == "yes")
{
    Dashes();
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write($"Oh thats cool! I once knew a {myLastName}, he was a cool dude. Anyway... ");
    Console.ReadLine();
    Console.WriteLine($"Mr. {myLastName}, would you like to play the lucky number game, yes or no?");
    Console.ResetColor();
    PromptQuestion();
}

else
{
    string truelastNameValue = "";
    while (truelastNameValue == "")
    {
        Dashes();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Please enter your last name?");
        Console.ResetColor();
        TypeAnswer();
        truelastNameValue = Console.ReadLine();
    }

    Dashes();
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"Okay Mr. {truelastNameValue} would you like to play the lucky number game, yes or no?");
    Console.ResetColor();
    PromptQuestion();
}
void PromptQuestion()
{
    bool hasPlayed = false;

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
}
void PlayGame()
{
    string gameAnswer = "yes";
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
void TypeAnswer()
{
    Console.Write("Type in your answer: ");
}
void Dashes()
{
    Console.WriteLine("------------------------------------------------------------------");
}
