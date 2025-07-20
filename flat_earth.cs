Console.Write("Is the Earth flat?\n1: Yes\n2: No\nAnswer: ");
string userValue = Console.ReadLine();
int num;

while (!int.TryParse(userValue, out num) || (num != 1 && num != 2))
{
    Console.Write("Invalid input. Please enter 1 or 2: ");
    userValue = Console.ReadLine();
}
string message = num == 1 ? "Your head is flat" : "Correct";
Console.Write($"{message}");


/*
Console.Write("Is the Earth flat?\n1: Yes\n2: No\nAnswer: ");
string userValue = Console.ReadLine();
int num;
string message;

while (!int.TryParse(userValue, out num) || (num != 1 && num != 2))
{
    Console.Write("Invalid input. Please enter 1 or 2: ");
    userValue = Console.ReadLine();
}

if (num == 1)
{
    Console.ForegroundColor = ConsoleColor.Red;
    message = "Your head is flat.";
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    message = "Correct.";
}

Console.WriteLine(message);
Console.ResetColor();
*/
