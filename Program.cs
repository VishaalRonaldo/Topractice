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
        Cat dog = new Cat();

        dog.Eat();   // Inherited from Animal
        dog.Bark();  // Dog's own method
    }
}