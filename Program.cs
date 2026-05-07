using System;

class Animal
{
    public void Eat()
    {
        Console.WriteLine("The animal is eating");
    }
}

class sheep : Animal
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
        sheep cat = new sheep();

        cat.Eat();   // Inherited from Animal
        cat.Bark();  // Dog's own method
    }
}