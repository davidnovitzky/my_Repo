Console.Write("Is the Earth round?\n1: Yes\n2: No\nAnswer: ");
string userValue = Console.ReadLine();
int num;

while (!int.TryParse(userValue, out num) || (num != 1 && num != 2))
{
    Console.Write("Invalid input. Please enter 1 or 2: ");
    userValue = Console.ReadLine();
}
string message = num == 1 ? "correct" : "not correct";
Console.Write($"Your answer is {message}");
Console.ReadLine();
