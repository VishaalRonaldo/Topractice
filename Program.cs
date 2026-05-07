using System;

class Animal
{
    public void Eat()
    {
        Console.WriteLine("The animal is eating");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("The dog is barking");
    }
}

class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine("The cat is meowing");
    }
}


class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog();

        dog.Eat();   // Inherited from Animal
        dog.Bark();  // Dog's own method

        Cat cat = new Cat();
        cat.Eat();   // Inherited from Animal
        cat.Meow();  // Cat's own method
        Console.WriteLine("Press any key to exit...");
    }
}