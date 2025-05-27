Console.Write("How many students? "); //asks the user how many students there are
int studentCount = int.Parse(Console.ReadLine()); // read and store the input as an integer

int[] grades = new int[studentCount]; // initializes an array of the students count from the integer variable above
float total = 0; // variable to keep track of total sum of grades for average calculation
string feedback; // variable to store feedback for each student and display it later

int currentSmallest = int.MaxValue; // variable to hold the smallest grade value starting with max
int currentLargest = int.MinValue; // variable to hold the largest grade value starting with min

for (int i = 0; i < grades.Length; i++) // loop to collect each grade from the students; length of grades array
{
    Console.Write($"Enter grade for student {i + 1}: "); // prompt the user to enter grade for student in each index +1 to display student number from 1 not 0
    grades[i] = int.Parse(Console.ReadLine()); // read the value and store it in grades array and appropriate index

    if (grades[i] < currentSmallest) currentSmallest = grades[i]; // if that grade is smaller then the currentsmallest assigned then this grade is assigned as the currentsmallest.
    if (grades[i] > currentLargest) currentLargest = grades[i]; // if that grade is larger then the currentlargest assigned then this grade is assigned as the currentlargest.

    total += grades[i]; // adds up all the grades inside the total variable for later average calculation
}
Console.WriteLine(); // blank line for separation

for (int i = 0; i < grades.Length; i++) // loop to show each students grade and feedback
{
    feedback = grades[i] switch // the feedback value is assigned based on grades of each indexed student using switches
    {
        >= 90 and <= 100 => "Excellent!", // if score >= 90 and <= 100 feedback is assigned
        >= 70 and <= 89 => "Good Job!",   // if score >= 70 and <= 89 feedback is assigned
        >= 50 and <= 69 => "You passed!", // if score >= 50 and <= 69 feedback is assigned
        >= 0 and <= 49 => "You failed",   // if score >= 0 and <= 49 feedback is assigned
        _ => "Invalid Score"              // if the input is invalid display invalid score
    };

    Console.Write($"Student {i + 1} score : {grades[i]} - {feedback}"); // shows students number score and feedback
    Console.ReadLine(); // waits for user to press enter to show each students score and feedback
}
Console.WriteLine(); // blank line for separation

float average = total / studentCount; // average calculated from the total gathered grades and divided by the student count of the array

if (average == Math.Floor(average)) Console.WriteLine($"Average grade: {average:F0}"); // // Display average with formatting: no decimals if it's a whole number, 1 decimal if not
else Console.WriteLine($"Average grade: {average:F1}");

Console.WriteLine($"Highest grade: {currentLargest}"); // displays the highest grade
Console.WriteLine($"Lowest grade: {currentSmallest}"); // displaye the smallest grade
Console.ReadLine(); // Waits for user to press Enter before ending the program
