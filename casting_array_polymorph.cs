Dog dog = new Dog();
Cat cat = new Cat();
Bird bird = new Bird();

Animal[] animals = { dog, cat, bird };

foreach (Animal animal in animals)
{
    animal.MakeSound();
}
class Animal
{
    public virtual void MakeSound() 
    {

    }
}
class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
}
class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
}
class Bird : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Tweet!");
    }
}
