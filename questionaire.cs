Console.WriteLine("Welcome to the Quiz!");

string questionOne = "Question 1: What is the closest planet to the Sun?";
string questionTwo = "Question 2: What is the largest planet in the Solar System?";
string questionThree = "Question 3: What is the closest galaxy to the Milky Way?";

int score = 0;
int questionQty = 0;

Console.WriteLine();
Console.WriteLine(questionOne);
questionQty += 1;
Console.Write("Your answer: ");
string answerOne = Console.ReadLine();

switch (answerOne.ToLower())
{
    case "mercury":
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Correct!");
        Console.ResetColor();
        score += 1;
        break;
    default:
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Incorrect!");
        Console.ResetColor();
        break;
}

//if (answerOne.ToLower() == "mercury")
//{
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine("Correct!");
//    Console.ResetColor();
//    score += 1;
//}

//else
//{
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine("Incorrect!");
//    Console.ResetColor();
//}

Console.WriteLine();
Console.WriteLine(questionTwo);
questionQty += 1;
Console.Write("Your answer: ");
string answerTwo = Console.ReadLine();

if (answerTwo.ToLower() == "jupiter")
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Correct!");
    Console.ResetColor();
    score += 1;
}

else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Incorrect!");
    Console.ResetColor();
}

Console.WriteLine();
Console.WriteLine(questionThree);
questionQty += 1;
Console.Write("Your answer: ");
string answerThree = Console.ReadLine();

if (answerThree.ToLower() == "andromeda")
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Correct!");
    Console.ResetColor();
    score += 1;
}

else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Incorrect!");
    Console.ResetColor();
}

Console.WriteLine();
Console.WriteLine($"You got {score} out of {questionQty} correct!");
Console.ReadLine();
