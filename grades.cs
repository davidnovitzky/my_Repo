using System.Numerics;

Console.Write("How many students? ");
int studentCount = int.Parse(Console.ReadLine());

int[] grades = new int[studentCount];

float total = 0;
int currentSmallest = int.MaxValue;
int currentLargest = int.MinValue;

for (int i = 0; i < grades.Length; i++)
{
    Console.Write($"Enter grade for student {i+1}: ");
    grades[i] = int.Parse(Console.ReadLine());

    if (grades[i] < currentSmallest)
    {
        currentSmallest = grades[i];
    }
    if (grades[i] > currentLargest)
    {
        currentLargest = grades[i];
    }
    total = total + grades[i];
}

float average = total / studentCount;

Console.WriteLine();
Console.WriteLine($"Average grade: {average.ToString("F2")}");
Console.WriteLine($"Highest grade: {currentLargest}");
Console.WriteLine($"Lowest grade: {currentSmallest}");
Console.ReadLine();