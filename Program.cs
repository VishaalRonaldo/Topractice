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

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog();

        dog.Eat();   // Inherited from Animal
        dog.Bark();  // Dog's own method
    }
}