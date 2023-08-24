using System;

// Abstract base class
abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public abstract void MakeSound(); // Abstract method for making a sound
}

// Derived class Dog
class Dog : Animal
{
    public Dog(string name, int age) : base(name, age)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("Woof! Woof!"); // Dog sound
    }

    public void Fetch()
    {
        Console.WriteLine($"{Name} is fetching the ball."); // Dog-specific behavior
    }
}

// Derived class Cat
class Cat : Animal
{
    public Cat(string name, int age) : base(name, age)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("Meow!"); // Cat sound
    }

    public void Purr()
    {
        Console.WriteLine($"{Name} is purring."); // Cat-specific behavior
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog("Buddy", 3);
        dog.MakeSound(); // Woof! Woof!
        dog.Fetch();     // Buddy is fetching the ball.

        Cat cat = new Cat("Whiskers", 2);
        cat.MakeSound(); // Meow!
        cat.Purr();      // Whiskers is purring.
    }
}
