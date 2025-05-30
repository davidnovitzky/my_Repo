using static System.Net.Mime.MediaTypeNames;

DateTime today = DateTime.Now;

Console.ForegroundColor = ConsoleColor.White;
Console.Write("Today's date is: {0}", today.ToLongDateString());
Console.ReadLine();

Dashes();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("WELCOME TO THE LUCKY NUMBER GAME");
Console.ResetColor();

string myFirstName = Console.ReadLine();
while (myFirstName == "")
{
    Dashes();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Please enter your name");
    Console.ResetColor();
    Console.Write("Type in your first name: ");
    myFirstName = Console.ReadLine();
}

Dashes();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Please enter your last name");
Console.ResetColor();
Console.Write("Type in your last name: ");
string myLastName = Console.ReadLine();
while (myLastName == "")
{
    Dashes();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Please enter your last name");
    Console.ResetColor();
    Console.Write("Type in your last name: ");
    myLastName = Console.ReadLine();
}
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
    int.TryParse(myAge, out age); // <- Converts string to integer

} while (int.TryParse(myAge, out age) == false) ;


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
    Console.WriteLine("Sorry, you must be at least 18. Try again later.");
    Console.ReadLine();
    return;
}

Dashes();
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($"Very nice to have you here, {myFirstName}, did you say your last name was, {myLastName}, yes or no?");
Console.ResetColor();
TypeAnswer();

string lastNameValue = Console.ReadLine();
while (lastNameValue.ToLower() != "yes" && lastNameValue.ToLower() != "no")
{
    Dashes();
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"Very nice to have you here, {myFirstName}, did you say your last name was, {myLastName}, yes or no?");
    Console.ResetColor();
    TypeAnswer();
    lastNameValue = Console.ReadLine();
}

if (lastNameValue.ToLower() == "yes")
{
    Dashes();
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"Okay Mr. {myLastName}, would you like to play the lucky number game, yes or no?");
    Console.ResetColor();
    TypeAnswer();
    PlayGame();
}

else
{
    Dashes();
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("So what was your last name?");
    Console.ResetColor();
    TypeAnswer();

    string truelastNameValue = Console.ReadLine();
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
    TypeAnswer();
    PlayGame();
}

void PlayGame()
{
    string gameAnswer = Console.ReadLine();
    while (gameAnswer.ToLower() == "yes")
    {
        Dashes();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Pick a number - 1, 2 or 3");
        Console.ResetColor();
        TypeAnswer();

        string userValue = Console.ReadLine();
        string message;

        if (userValue == "1")
        {
            Dashes();
            message = "YOU WON THE GAME!";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(message);
            Console.ReadLine();
            return;
        }
        else if (userValue == "2")
        {
            Dashes();
            message = "You didn't win! Press Enter to continue";
        }
        else if (userValue == "3")
        {
            Dashes();
            message = "Sorry, better luck next time. Press Enter to continue";
        }
        else
        {
            Dashes();
            message = "Sorry, this number doesn't exist. Press Enter to continue";
        }

        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(message);
        Console.ResetColor();
        Console.ReadLine();

        Dashes();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Would you like to play the game again, yes or no?");
        Console.ResetColor();
        TypeAnswer();
        gameAnswer = Console.ReadLine();
    }
    // recursion "inception" (recursive method)
    if (gameAnswer.ToLower() != "no")
    {
        Dashes();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Please enter yes or no");
        Console.ResetColor();
        TypeAnswer();
        PlayGame(); // <- inception
                    // return stops the method execution from inception and doesnt continue past this block
                    // without return; the method would continue executing after the recursion
        return;
    }

    Dashes();
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
