const int correctPIN = 0377;
int attempts = 0;
int currentBalance = 100;

string repeat = "yes";

Console.Write("Press Enter to insert your card");
Console.ReadLine();
Console.WriteLine("Card Inserted.");

while (attempts < 3)
{
    Console.Write("Enter PIN number: ");
    string userInput = Console.ReadLine();
    int.TryParse(userInput, out int pinGuess);

    if (pinGuess == correctPIN)
    {
        Console.Write("Access granted");
        Console.ReadLine();
        break;
    }

    else
    {
        attempts++;

        if (attempts < 3)
        {
            Console.WriteLine("Incorrect PIN. Try again.");
        }
        else
        {
            Console.Write("Account locked. Too many failed attempts.");
            Console.ReadLine();
            Console.WriteLine("Press Enter to withdraw your card");
            Console.ReadLine();
            return;
        }
    }
}

while (repeat.ToLower() == "yes")
{
    Console.WriteLine($"Current Balance: ${currentBalance}");
    Console.Write("Would you like to withdraw or deposit: ");
    string answer = Console.ReadLine();
    while (answer.ToLower() != "withdraw" && answer.ToLower() != "deposit")
    {
        Console.Write("I'm sorry, I didn't get that: ");
        answer = Console.ReadLine();
    }

    if (answer.ToLower() == "withdraw")
    {
        Console.Write("How much would you like to withdraw: ");
        string withdraw = Console.ReadLine();
        int.TryParse(withdraw, out int withdrawAmount);

        if (withdrawAmount > currentBalance)
        {
            Console.WriteLine("I'm sorry, you have insufficient funds");
        }

        else
        {
            currentBalance -= withdrawAmount;
            Console.WriteLine("Withdrawal successful.");
            Console.WriteLine($"Remaining balance: ${currentBalance}");
        }
    }

    if (answer.ToLower() == "deposit")
    {
        Console.Write("How much would you like to deposit: ");
        string deposit = Console.ReadLine();
        int.TryParse(deposit, out int depositAmount); // <- error when input is a character

        currentBalance += depositAmount;
        Console.WriteLine("Deposit successful.");
        Console.WriteLine($"Current balance: ${currentBalance}");
    }

    Console.Write("Would you like another operation, yes or no: ");
    repeat = Console.ReadLine();
}

if (repeat.ToLower() == "no")
{
    Console.Write("Press Enter to withdraw your card ");
    Console.ReadLine();
    return;
}
