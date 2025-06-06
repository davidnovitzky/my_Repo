Console.WriteLine("Welcome to Console Cafe!");
Console.Write("Press Enter to continue...");
Console.ReadLine();
Console.WriteLine("");

string myName;

do
{
    Console.Write("What is your name? > ");
    myName = Console.ReadLine();
} while (myName == "");

const int burgerPrice = 5;
const int pizzaPrice = 7;
const int saladPrice = 4;
const int sodaPrice = 2;

int burgerQty = 0;
int pizzaQty = 0;
int saladQty = 0;
int sodaQty = 0;

string response = "yes";

Console.WriteLine("");
Console.WriteLine($"Hi, {myName}! Here's our menu:");
Console.WriteLine($"1. Burger - ${burgerPrice}");
Console.WriteLine($"2. Pizza  - ${pizzaPrice}");
Console.WriteLine($"3. Salad  - ${saladPrice}");
Console.WriteLine($"4. Soda   - ${sodaPrice}");

string menuAnswer;
int menuItem;

while (response.ToLower() == "yes")
{
    Console.WriteLine("");
    Console.Write("Please enter the number of item you want to order: > ");
    menuAnswer = Console.ReadLine();
    int.TryParse(menuAnswer, out menuItem); // <- crashes if blank or text input
    

    if (menuItem < 1 || menuItem > 4)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Invalid item number. Please try again.");
        Console.ResetColor();
        Console.ReadLine();
        continue; // <- starts the loop again, without it code below executes
    }

    
    string answerQty = "";
    int quantity;

   while (!int.TryParse(answerQty, out quantity))
   {
        Console.WriteLine("");
        Console.Write("How many would you like? > ");
        answerQty = Console.ReadLine();
        int.TryParse(answerQty, out quantity); // <- crashes if blank or text input

        if (!int.TryParse(answerQty, out quantity))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Invalid quantity number. Please try again.");
            Console.ResetColor();
            Console.ReadLine();
            continue; // <- starts the loop again, without it code below executes
        }
    }

    if (menuItem == 1)
    {
        burgerQty += quantity;
    }
    else if (menuItem == 2)
    {
        pizzaQty += quantity;
    }
    else if (menuItem == 3)
    {
        saladQty += quantity;
    }
    else if (menuItem == 4)
    {
        sodaQty += quantity;
    }

    do
    {
        Console.Write("Would you like to order another item? (yes/no) > ");
        response = Console.ReadLine();
    } while (response.ToLower() != "yes" && response.ToLower() != "no");
}

Console.WriteLine("");
Console.WriteLine("--- Order Summary ---");

int totalAmount = 0;

if (burgerQty > 0)
{
    int burgerTotal = burgerQty * burgerPrice;
    string burgerLabel = burgerQty == 1 ? "Burger" : "Burgers";
    Console.WriteLine($"{burgerQty} {burgerLabel} = ${burgerTotal}");
    totalAmount += burgerTotal;
}
if (pizzaQty > 0)
{
    int pizzaTotal = pizzaQty * pizzaPrice;
    string pizzaLabel = pizzaQty == 1 ? "Pizza" : "Pizzas";
    Console.WriteLine($"{pizzaQty} {pizzaLabel} = ${pizzaTotal}");
    totalAmount += pizzaTotal;
}
if (saladQty > 0)
{
    int saladTotal = saladQty * saladPrice;
    string saladLabel = saladQty == 1 ? "Salad" : "Salads";
    Console.WriteLine($"{saladQty} {saladLabel} = ${saladTotal}");
    totalAmount += saladTotal;
}
if (sodaQty > 0)
{
    int sodaTotal = sodaQty * sodaPrice;
    string sodaLabel = sodaQty == 1 ? "Soda" : "Sodas";
    Console.WriteLine($"{sodaQty} {sodaLabel} = ${sodaTotal}");
    totalAmount += sodaTotal;
}

Console.ForegroundColor = ConsoleColor.Red;
Console.Write($"Total: ");
Console.ResetColor();
Console.WriteLine($"${totalAmount}");
Console.WriteLine("");
Console.WriteLine($"Thank you for your order, {myName}! Have a great day!");
Console.ReadLine();
