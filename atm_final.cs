string correctPIN = "0377";
int attempts = 0;
int currentBalance = 100;
int withdrawAmount;
int depositAmount;
bool keepRunning = true;

keepRunning = DisplayLoginSystem();

while (keepRunning == true)
{
    int mainMenuInput = DisplayMainMenu();

    switch (mainMenuInput)
    {
        case 1:
            keepRunning = DisplayCurrentBalance();
            break;
        case 2:            
            keepRunning = DisplayPromptDepositAmount();
            break;
        case 3:
            keepRunning = DisplayPromptWithdrawAmount();
            break;
        case 4:
            keepRunning = DisplayChangePINMenu();
            break;
        case 5:
            keepRunning = false;
            break;
        default:
            Console.WriteLine("------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid choice..");
            Console.ResetColor();
            Console.WriteLine("------------------------");
            break;
    }
}
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Withdrawing your card...");
Console.WriteLine("Bye bye");
Console.ReadLine();

bool DisplayChangePINMenu()
{
    Console.WriteLine("------------------------");
    Console.WriteLine($"Your current 4 digit PIN code is: {correctPIN}");
    string newPinInput;
    do
    {
        Console.Write("Enter your new PIN: ");
        newPinInput = Console.ReadLine();
    } while (string.IsNullOrWhiteSpace(newPinInput) || newPinInput.Length != 4 || !newPinInput.All(char.IsDigit));
    string confirmNewPin;
    do
    {
        Console.Write("Confirm your new PIN: ");
        confirmNewPin = Console.ReadLine();
    } while (string.IsNullOrWhiteSpace(confirmNewPin) || confirmNewPin.Length != 4 || !confirmNewPin.All(char.IsDigit));

    while (confirmNewPin != newPinInput)
    {
        Console.WriteLine("------------------------");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The PINs do not match. Please try again.");
        Console.ResetColor();
        Console.WriteLine("------------------------");
        do
        {
            Console.Write("Enter your new PIN: ");
            newPinInput = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(newPinInput) || newPinInput.Length != 4 || !newPinInput.All(char.IsDigit));

        do
        {
            Console.Write("Confirm your new PIN: ");
            confirmNewPin = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(confirmNewPin) || confirmNewPin.Length != 4 || !confirmNewPin.All(char.IsDigit));
    }
    if (confirmNewPin == newPinInput)
    {
        correctPIN = confirmNewPin;
        Console.WriteLine("------------------------");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Your PIN has been changed successfully.");
        Console.ResetColor();
    }
    return PromptReturnToMainMenu();
}
bool DisplayPromptDepositAmount()
{
    Console.WriteLine("------------------------");
    Console.Write("How much would you like to deposit: ");
    string deposit = Console.ReadLine();
    int.TryParse(deposit, out depositAmount);

    while (!int.TryParse(deposit, out depositAmount) || depositAmount <= 0)
    {
        Console.WriteLine("------------------------");
        Console.Write("Please enter a valid number: ");
        deposit = Console.ReadLine();
        int.TryParse(deposit, out depositAmount);
    }

    currentBalance += depositAmount;
    Console.WriteLine("------------------------------");
    Console.WriteLine("Deposit successful.");
    Console.WriteLine($"Current balance: ${currentBalance}");
    Console.WriteLine("------------------------------");

    return PromptReturnToMainMenu();
}
int DisplayMainMenu()
{
    Console.WriteLine("Welcome to the main menu");
    Console.WriteLine("------------------------");
    Console.WriteLine("1. Check Balance\n2. Deposit\n3. Withdraw\n4. Change Pin\n5. Exit ");
    Console.Write("Enter your choice: ");
    string mainMenuChoice = Console.ReadLine();
    int.TryParse(mainMenuChoice, out int mainMenuInput);
    return mainMenuInput;
}
bool DisplayCurrentBalance() 
{
    Console.WriteLine("------------------------");
    Console.WriteLine($"Current Balance: ${currentBalance}");

    return PromptReturnToMainMenu();
}
bool DisplayPromptWithdrawAmount()
{
    Console.WriteLine("------------------------");
    Console.Write("How much would you like to withdraw: ");
    string withdraw = Console.ReadLine();
    int.TryParse(withdraw, out withdrawAmount);

    while (!int.TryParse(withdraw, out withdrawAmount) || withdrawAmount <= 0)
    {
        Console.Write("Please enter a valid amount: ");
        withdraw = Console.ReadLine();
        int.TryParse(withdraw, out withdrawAmount);
    }

    while (withdrawAmount > currentBalance)
    {
        Console.WriteLine("------------------------");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("I'm sorry, you have insufficient funds");
        Console.ResetColor();
        Console.WriteLine("------------------------");
        Console.WriteLine($"Your current balance: ${currentBalance}");
        Console.Write("Please enter a valid amount: ");
        withdraw = Console.ReadLine();
        int.TryParse(withdraw, out withdrawAmount);
    }

        currentBalance -= withdrawAmount;
        Console.WriteLine("------------------------------");
        Console.WriteLine("Withdrawal successful.");
        Console.WriteLine($"Remaining balance: ${currentBalance}");
        Console.WriteLine("------------------------------");

    return PromptReturnToMainMenu();
}
bool DisplayLoginSystem()
{
    Console.Write("Press Enter to insert your card");
    Console.ReadLine();
    Console.WriteLine("Card Inserted.");

    while (attempts <= 3)
    {
        Console.Write("Enter PIN number: ");
        string userInput = Console.ReadLine();

        if (userInput == correctPIN)
        {
            Console.Write("Access granted");
            Console.ReadLine();
            Console.Clear();
            return true;
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
                Console.WriteLine("Account locked. Too many failed attempts.");
                Console.Write("Press Enter to withdraw your card");
                Console.ReadLine();
                return false;
            }
        }
    }
    return false;
}
bool PromptReturnToMainMenu()
{
    Console.Write("Would you like to go back to the main menu, yes or no: ");
    string answerMainMenu = Console.ReadLine().ToLower();

    while (answerMainMenu != "yes" && answerMainMenu != "no")
    {
        Console.WriteLine("------------------------");
        Console.Write("Please enter yes or no: ");
        answerMainMenu = Console.ReadLine().ToLower();
    }

    if (answerMainMenu.ToLower() == "yes")
    {
        Console.WriteLine("------------------------");
        return true;
    }

    else
    {
        Console.Write("Press Enter to withdraw your card ");
        Console.ReadLine();
        return false;
    }
}
