Console.Write("How many students? ");
int studentCount = int.Parse(Console.ReadLine());

int[] grades = new int[studentCount];
float total = 0;
string feedback;

int currentSmallest = int.MaxValue;
int currentLargest = int.MinValue;

for (int i = 0; i < grades.Length; i++)
{
    Console.Write($"Enter grade for student {i + 1}: ");
    grades[i] = int.Parse(Console.ReadLine());

    if (grades[i] < currentSmallest) currentSmallest = grades[i];
    if (grades[i] > currentLargest)  currentLargest = grades[i];

    total += grades[i];
}
Console.WriteLine();

for (int i = 0; i < grades.Length; i++)
{
    int score = grades[i];
    
    if (score >= 90 && score <= 100)     feedback = "Excellent!";
    else if (score >= 70 && score <= 89) feedback = "Good Job!";
    else if (score >= 50 && score <= 69) feedback = "You passed!";
    else if (score >= 0 && score <= 49)  feedback = "You failed";
    else                                 feedback = "Invalid Score";

    Console.Write($"Student {i + 1} score : {score} - {feedback}");
    Console.ReadLine();
}
Console.WriteLine();

float average = total / studentCount;

if (average == Math.Floor(average)) Console.WriteLine($"Average grade: {average:F0}");
else                                Console.WriteLine($"Average grade: {average:F1}");

Console.WriteLine($"Highest grade: {currentLargest}");
Console.WriteLine($"Lowest grade: {currentSmallest}");
Console.ReadLine();
