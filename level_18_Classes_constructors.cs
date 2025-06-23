Pet newCat = new(PetType.Cat, "Bagira", 8, 8); // calling the constructor, used to set up the object’s data.

class Pet // class - blueprint to create objects
{
    public PetType Type;
    public string Name; // fields - variable inside a class to store data about the object
    public int Age;     // fields - belong to the object
    public int Weight;

    // The parameters (string name, etc.) come from outside
    public Pet(PetType type, string name, int age, int weight) // defining the constructor
    {
        Type = type;
        Name = name; // Assigns the input value to the object’s field when calling the constructor
        Age = age;
        Weight = weight;
    }
}
enum PetType { Cat, Dog }

Pet newCat = new Pet();

newCat.name = "Bagira";
newCat.age = 8;
newCat.weight = 8;

class Pet
{
    public string name;
    public int age;
    public int weight;
}
