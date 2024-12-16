using System;

// Base class representing a general Animal
public class Animal
{
    public void Eat()
    {
        Console.WriteLine("This animal is eating.");
    }
}

// Dog class inherits from Animal (Single Inheritance)
public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("The dog is barking.");
    }
}

// Interfaces for multiple inheritance
public interface IWalkable
{
    void Walk();
}

public interface IPlayful
{
    void Play();
}

// Cat class implementing both IWalkable and IPlayful (Multiple Inheritance using interfaces)
public class Cat : IWalkable, IPlayful
{
    public void Walk()
    {
        Console.WriteLine("The cat is walking.");
    }

    public void Play()
    {
        Console.WriteLine("The cat is playing.");
    }
}

// Base class for Vehicle
public class Vehicle
{
    public void StartEngine()
    {
        Console.WriteLine("The vehicle's engine is starting.");
    }
}

// Car class inherits from Vehicle (Multilevel Inheritance)
public class Car : Vehicle
{
    public void Drive()
    {
        Console.WriteLine("The car is driving.");
    }
}

// ElectricCar inherits from Car (Multilevel Inheritance continued)
public class ElectricCar : Car
{
    public void ChargeBattery()
    {
        Console.WriteLine("The electric car is charging.");
    }
}

// Base class for Bird
public class Bird
{
    public void Fly()
    {
        Console.WriteLine("The bird is flying.");
    }
}

// Sparrow and Parrot classes both inherit from Bird (Hierarchical Inheritance)
public class Sparrow : Bird
{
    public void Sing()
    {
        Console.WriteLine("The sparrow is singing.");
    }
}

public class Parrot : Bird
{
    public void Talk()
    {
        Console.WriteLine("The parrot is talking.");
    }
}

class Program
{
    static void Main()
    {
        // Demonstrating Single Inheritance
        Dog dog = new Dog();
        dog.Eat();
        dog.Bark();

        // Demonstrating Multiple Inheritance
        Cat cat = new Cat();
        cat.Walk();
        cat.Play();

        // Demonstrating Multilevel Inheritance
        ElectricCar electricCar = new ElectricCar();
        electricCar.StartEngine();
        electricCar.Drive();
        electricCar.ChargeBattery();

        // Demonstrating Hierarchical Inheritance
        Sparrow sparrow = new Sparrow();
        sparrow.Fly();
        sparrow.Sing();

        Parrot parrot = new Parrot();
        parrot.Fly();
        parrot.Talk();
    }
}
