// create an integer variable for correctPIN with assigned PIN
const int correctPIN = 0377;
// create an integer variable for currentBalance with assigned balance
int currentBalance = 100;
// create an integer variable for withdrawAmount
int withdrawAmount;
// create an integer variable for depositAmount
int depositAmount;
// create an integer variable for pinGuess1
int pinGuess1;
// create an integer variable for pinGuess2
int pinGuess2;
// create an integer variable for pinGuess3
int pinGuess3;
// create a string variable for repeat operation
string repeat = "yes";

// display prompt to insert card
Console.Write("Press Enter to insert your card");
// wait for user input
Console.ReadLine();
Console.WriteLine("Card Inserted.");

// display prompt to enter pin number
Console.Write("Enter PIN number: ");
// convert string to integer
// input to pinguess1 variable
pinGuess1 = Int32.Parse(Console.ReadLine());
// check if pinguess1 is the same as correctPIN
if (pinGuess1 != correctPIN) // <- how to loop this three times
{
    // if not prompt user to enter pin number again
    Console.Write("Incorrect PIN. Enter PIN number: ");
    pinGuess2 = Int32.Parse(Console.ReadLine());

    if (pinGuess2 != correctPIN)
    {
        Console.Write("Incorrect PIN. Enter PIN number: ");
        pinGuess3 = Int32.Parse(Console.ReadLine());

        if (pinGuess3 != correctPIN)
        {
            // if not display Account locked. Too many failed attempts.
            Console.WriteLine("Account locked. Too many failed attempts.");
            Console.ReadLine();
            return;
        }
    }
}
// loop if yes prompt with question to withdraw or deposit
while (repeat.ToLower() == "yes")
{
    // if yes go to currentBalance
    // prompt with current balance
    Console.WriteLine($"Current Balance: ${currentBalance}");
    // prompt with question to withdraw or deposit
    Console.Write("Would you like to withdraw or deposit: ");
    // declare a string variable with the user input
    string answer = Console.ReadLine();
    // if withdrawing prompt for amount to withdrawAmount
    while (answer.ToLower() != "withdraw" && answer.ToLower() != "deposit")
    {
        Console.Write("I'm sorry, I didn't get that: ");
        answer = Console.ReadLine();
    }

    if (answer.ToLower() == "withdraw")
    {
        Console.Write("How much would you like to withdraw: ");
        withdrawAmount = Int32.Parse(Console.ReadLine()); // <- error when input is a character

        if (withdrawAmount > currentBalance)
        {
            Console.WriteLine("I'm sorry, you have insufficient funds");
        }

        else
        {
            // subtract withdrawAmount from currentBalance variable
            currentBalance -= withdrawAmount;
            // display withdrawal successful
            Console.WriteLine("Withdrawal successful.");
            // show remaining balance
            Console.WriteLine($"Remaining balance: ${currentBalance}");
        }
    }

    if (answer.ToLower() == "deposit")
    {
        Console.Write("How much would you like to deposit: ");
        // if depositing prompt for amount to depositAmount
        depositAmount = Int32.Parse(Console.ReadLine()); // <- error when input is a character
                                                         // add depositAmount to currentBalance variable
        currentBalance += depositAmount;
        // display deposit successful
        Console.WriteLine("Deposit successful.");
        // show current balance
        Console.WriteLine($"Current balance: ${currentBalance}");
    }
    // prompt with question if we want another operation yes or no
    Console.Write("Would you like another operation, yes or no: ");
    repeat = Console.ReadLine();
}
// if no prompt the user to withdraw card and exit app
if (repeat.ToLower() == "no")
{
    Console.Write("Press Enter to withdraw your card ");
    Console.ReadLine();
    return;
}

/* ATM
 * Login system
 * 4 digit Pin
 * 3 attempts
 * If fail exit app
 * If success show main menu
 * MAIN MENU
 * Check balance
 * Deposit
 * Withdraw
 * Exit
 * ---------------
 * Check balance
 * Show Balance
 * Back
 * Exit
 * --------------
 * Deposit
 * How much?
 * Add to balance
 * Show balance?
 * Back
 * Exit
 * --------------
 * Withdraw
 * How much?
 * Check if enough balance
 * Subtract from balance
 * Show balance?
 * back 
 * Exit
 * */
