string[] weekday = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
decimal[] dailyCalories = new decimal[7];
decimal totalCalories = 0;

Console.Write("Enter your weight in kg: ");
int weight = int.Parse(Console.ReadLine());
Console.Clear();

for (int i = 0; i < weekday.Length; i++)
{
    Console.Write($"Enter calories for {weekday[i]}: ");
    dailyCalories[i] = decimal.Parse(Console.ReadLine());
    totalCalories += dailyCalories[i];
}

decimal averageCalorieIntake = totalCalories / weekday.Length;
Console.WriteLine($"Average calories consumed in the week: {averageCalorieIntake:F2}");

int normalCalorieIntake = 24 * weight; // Assuming 24 calories per kg of body weight

Console.WriteLine($"Normal calorie intake for your weight ({weight} kg): {normalCalorieIntake} calories");

decimal dangerouslyLow = normalCalorieIntake * 0.70m;
decimal underEating = normalCalorieIntake * 0.89m;
decimal healthyLow = normalCalorieIntake * 0.90m;
decimal healthyHigh = normalCalorieIntake * 1.10m;
decimal slightlyOver = normalCalorieIntake * 1.25m;
decimal significantlyOver = normalCalorieIntake * 1.50m;

if (averageCalorieIntake < dangerouslyLow)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("You're not eating enough");
}
else if (averageCalorieIntake >= dangerouslyLow && averageCalorieIntake <= underEating)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("You are at a low level of caloric intake. You might be losing weight.");
}
else if (averageCalorieIntake >= healthyLow && averageCalorieIntake <= healthyHigh)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("You are at a healthy level.");
}
else if (averageCalorieIntake > healthyHigh && averageCalorieIntake <= slightlyOver)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("You're slightly overeating — you might gain weight over time.");
}
else if (averageCalorieIntake > slightlyOver && averageCalorieIntake <= significantlyOver)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("You are eating more than needed — possible weight gain.");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("You're overeating significantly. Consider cutting back.");
}
