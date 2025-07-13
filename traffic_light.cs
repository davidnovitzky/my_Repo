Person newPerson = new Person()
{
    Gender = Gender.Male,
    FirstName = "David",
    LastName = "Novitzky",
    DateOfBirth = new DateTime(1990, 10, 1),
    Nationality = "Lithuanian",
};
Console.WriteLine($"{newPerson.FirstName} is {newPerson.Age} years old.");

if (newPerson.Age >= 18)
    Console.WriteLine($"{newPerson.FirstName} is an adult.");
else
    Console.WriteLine($"{newPerson.FirstName} is a minor.");

Person[] people = { newPerson };

Console.WriteLine($"{people[0].FirstName} is the first person in the list");
class Person
{
    public int Age => GetAge(); // Property to get the age using the GetAge method
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Gender Gender { get; set; }
    public string Nationality { get; set; } 

    public int GetAge()
    {
        DateTime today = DateTime.Today; // get todays date
        int age = today.Year - DateOfBirth.Year; // calculates age difference in years
        if (DateOfBirth > today.AddYears(-age))
        {
            age--; // subtract 1 year if birthday not happened yet this year
        }
        return age; // returns the final age
    }
}
enum Gender { Male, Female }
