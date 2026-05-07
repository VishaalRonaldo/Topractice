using System;

class Animal
{
    public void Eat()
    {
        Console.WriteLine("The animal is eating");
    }
}

class dog : Animal
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
        dog dogs = new dog();

        dogs.Eat();   // Inherited from Animal
        dogs.Bark();  // Dog's own method

        Cat cat = new Cat();
        cat.Eat();   // Inherited from Animal
        cat.Meow();  // Cat's own method
        Console.WriteLine("Press any key to exit...");
    }
}