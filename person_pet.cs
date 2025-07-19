Dog Marley = new Dog("Marley", 3);
Cat Luna = new Cat("Luna");
Dog Ninja = new Dog("Ninja");

Person Jane = new Person("Jane", 30, Marley);
Person John = new Person("John", 25, Luna);
Person Dave = new Person("Dave", 34, Ninja);

Person[] people = { Jane, John, Dave };
Pet[] pets = { Marley, Luna, Ninja };

foreach (Pet pet in pets)
{
    Console.WriteLine($"{pet.Name} is a {pet.Type}.");
    Console.WriteLine(pet.MakeSound());
    Console.WriteLine();
}

foreach (Person person in people)
{
    Console.WriteLine($"{person.Name} is {person.Age} years old. And {person.DoesHavePet()}");
    person.Walk();
    person.Sleep();
    Console.WriteLine($"The pet is a {person.Pet.Type}, it's name is {person.Pet.Name} and {person.Pet.MakeSound()}");
    Console.WriteLine($"{person.Pet.Name} has {person.Pet.NumberOfLegs} legs.");
    Console.WriteLine();
}
Console.WriteLine($"There are a total of {Person.NumberOfPeople} people created.");
Console.WriteLine($"There are a total of {Pet.numberOfPets} pets created.");

class Person
{
    public string Name { get; }
    public int Age { get; }
    public Pet Pet { get; }
    public static int NumberOfPeople { get; private set; }

    public Person(string name, int age, Pet pet)
    {
        Name = name;
        Age = age;
        Pet = pet;
        NumberOfPeople++;
    }

    public void Walk()
    {
        Console.WriteLine($"{Name} can walk.");
    }
    public void Sleep()
    {
        Console.WriteLine($"{Name} can sleep.");
    }
    public string DoesHavePet()
    {
        return Pet != null ? $"{Name} has a pet." : $"{Name} does not have a pet.";
    }
}
class Pet
{
    public string Name { get; }
    public string Type { get; }
    public static int numberOfPets;
    public int NumberOfLegs { get; protected set; }
    public Pet(string name, string type, int numberOfLegs = 4)
    {
        Name = name;
        Type = type;
        NumberOfLegs = numberOfLegs;
        numberOfPets++;
    }
    public virtual string MakeSound()
    {
        return $"{Name} makes a sound.";
    }
    public int GetNumberOfLegs(int numberOfLegs)
    {
        return NumberOfLegs = numberOfLegs;
    }
}
class Dog : Pet
{
    
    public Dog(string name, int numberOfLegs = 4) : base(name, "Dog")
    {
        NumberOfLegs = numberOfLegs;
    }
    public override string MakeSound()
    {
        return $"{Name} barks.";
    }
}
class Cat : Pet
{
    public Cat(string name, int numberOfLegs = 4) : base(name, "Cat")
    {
    }
    public override string MakeSound()
    {
        return $"{Name} meows.";
    }
}
