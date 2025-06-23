Pet newCat = new(PetType.Cat, "Bagira", 8, 8); // calling the constructor

class Pet
{
    public PetType Type;
    public string Name;
    public int Age;
    public int Weight;

    public Pet(PetType type, string name, int age, int weight) // defining the constructor
    {
        Type = type;
        Name = name;
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
