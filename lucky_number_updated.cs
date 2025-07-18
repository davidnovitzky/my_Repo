Player player = new Player();
Console.WriteLine(player.Name);
Console.WriteLine(player.Surname);
Console.WriteLine(player.Age);
Console.WriteLine(player.IsEligibleForGame());



class Player
{
    public string Name { get; }
    public string Surname { get; }
    public int Age { get; }
    public Player()
    {
        Name = PromptString("Enter your name > ");
        Surname = PromptString("Enter your surname > ");
        Age = PromptInt("Enter your age > ");
    }
    public string PromptString(string message)
    {
        while (true)
        {
            Console.Write(message);
            string? name = Console.ReadLine();

            if (!string.IsNullOrEmpty(name) && name.All(char.IsLetter))
            {
                return name;
            }
        }
    }
    public int PromptInt(string message)
    {
        while (true)
        {
            Console.Write(message);
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int result) && result > 0)
            {
                return result;
            }
        }
    }
    public bool IsEligibleForGame()
    {
        int minAge = 18;
        int yearsUntilMinAge = minAge - Age;

        if (Age >= minAge)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("You are old enough.");
            Console.ResetColor();

            return true;
        }

        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            string yearsLabel = (yearsUntilMinAge == 1) ? "year" : "years";
            Console.WriteLine($"Sorry, you must be at least 18. Try again in {yearsUntilMinAge} {yearsLabel}");
            Console.ResetColor();

            return false;
        }
    }
}
