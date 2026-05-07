using System;

class Animal
{
    public void Eat()
    {
        Console.WriteLine("The animal is eating");
    }
}

class Cat : Animal
{
    public void Bark()
    {
        Console.WriteLine("The dog is barking");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Cat cat = new Cat();

        cat.Eat();   // Inherited from Animal
        cat.Bark();  // Dog's own method
    }
}