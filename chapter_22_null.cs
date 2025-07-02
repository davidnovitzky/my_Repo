Person newPerson = new Person();
/*newPerson.Name = "David";*/ // null
newPerson.PrintNameLength(); // output is 7

public class Person
{
    public string? Name; // A non-nullable variable cannot hold a null value so add ? operator
    // declare the field as nullable by adding the ? operator so it can hold null

    public void PrintNameLength()
    {
        Console.WriteLine(Name?.Length ?? 0);
        // after adding the ? operator when declaring the field
        // add the ! operator to say that the field wont be null
        // do a null-check with an if statement:

        //if (Name != null)
        //{
        //    Console.WriteLine(Name.Length);
        //}
    }
}
