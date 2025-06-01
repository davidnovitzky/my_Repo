const string correctPIN = "0377";
int attempts = 0;
int currentBalance = 100;
int withdrawAmount;
int depositAmount;

string repeat = "yes";

Console.Write("Press Enter to insert your card");
Console.ReadLine();
Console.WriteLine("Card Inserted.");

while (attempts < 3)
{
    Console.Write("Enter PIN number: ");
    string userInput = Console.ReadLine();

    if (userInput == correctPIN)
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
        Console.Write("Please choose withdraw or deposit: ");
        answer = Console.ReadLine();
    }

    if (answer.ToLower() == "withdraw")
    {
        Console.Write("How much would you like to withdraw: ");
        string withdraw = Console.ReadLine();

        while (!int.TryParse(withdraw, out withdrawAmount) || withdrawAmount <= 0)
        {
            Console.Write("Please enter a valid amount: ");
            withdraw = Console.ReadLine();
        }

        if (withdrawAmount > currentBalance)
        {
            Console.WriteLine("I'm sorry, you have insufficient funds");
        }
        else
        {
            currentBalance -= withdrawAmount;
            Console.WriteLine("------------------------------");
            Console.WriteLine("Withdrawal successful.");
            Console.WriteLine($"Remaining balance: ${currentBalance}");
            Console.WriteLine("------------------------------");
        }
    }

    if (answer.ToLower() == "deposit")
    {
        Console.Write("How much would you like to deposit: ");
        string deposit = Console.ReadLine();

        while (!int.TryParse(deposit, out depositAmount) || depositAmount <= 0)
        {
            Console.Write("Please enter a valid number: ");
            deposit = Console.ReadLine();
        }          
        currentBalance += depositAmount;
        Console.WriteLine("------------------------------");
        Console.WriteLine("Deposit successful.");
        Console.WriteLine($"Current balance: ${currentBalance}");
        Console.WriteLine("------------------------------");
    }

    Console.Write("Would you like another operation, yes or no: ");
    repeat = Console.ReadLine();

    while (repeat.ToLower() != "yes" && repeat.ToLower() != "no")
    {
        Console.Write("Please enter yes or no: ");
        repeat = Console.ReadLine();
    }
}

if (repeat.ToLower() == "no")
{
    Console.Write("Press Enter to withdraw your card ");
    Console.ReadLine();
    return;
}
