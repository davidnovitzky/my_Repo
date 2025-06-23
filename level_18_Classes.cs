// Create a new Pet object named 'goodBoi' using the constructor and assign values
Pet goodBoi = new(PetType.Dog, "Brutus", "Golden Retriever", 65);

// Print the type of the pet (e.g., Dog)
Console.WriteLine($"Pet: {goodBoi.Type}");

// Print the name of the pet
Console.WriteLine($"Name: {goodBoi.Name}");

// Print the breed of the pet
Console.WriteLine($"Breed: {goodBoi.Breed}");

// Print the weight of the pet in pounds
Console.WriteLine($"Weight: {goodBoi.Weight} lbs.");


// Define a class named 'Pet' (this is the blueprint for creating Pet objects)
public class Pet
{
    // These are the fields (variables) that store the pet's data
    public PetType Type;
    public string Name;
    public string Breed;
    public int Weight;

    // This is the constructor — it sets up a new Pet with the given values
    public Pet(PetType type, string name, string breed, int weight)
    {
        Type = type;     // Set the Type field (e.g., Dog or Cat)
        Name = name;     // Set the Name field
        Breed = breed;   // Set the Breed field
        Weight = weight; // Set the Weight field
    }
}

// Define an enum (a list of named values) to describe possible pet types
public enum PetType { Dog, Cat }
