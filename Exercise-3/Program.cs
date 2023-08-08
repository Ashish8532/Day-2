using System;

namespace Exercise_3
{
    // Abstract class for animals
    abstract class Animal
    {
        // Properties of an animal
        public string? Name; // Name of the animal (can be null)
        public int Age;      // Age of the animal

        // Abstract method for making a sound
        // The body of this method must be provided by derived classes
        public abstract void MakeSound();
    }

    // Interface for movable objects
    interface IMovable
    {
        void Move(); // Method to define movement behavior
    }

    // First derived class: Dog
    class Dog : Animal, IMovable
    {
        public override void MakeSound()
        {
            // Implementation of the MakeSound method for a dog
            Console.WriteLine("Dog Sounds - Woof Woof...");
        }

        public void Move()
        {
            // Implementation of the Move method for a dog
            Console.WriteLine("This is the Move() method.");
        }
    }

    // Second derived class: Cat
    class Cat : Animal, IMovable
    {
        public override void MakeSound()
        {
            // Implementation of the MakeSound method for a cat
            Console.WriteLine("Cat Sounds - Meow Meow...\n");
        }

        public void Move()
        {
            // Implementation of the Move method for a cat
            Console.WriteLine("This is the Move() method.");
        }
    }

    // Main program class or Driver Class
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Dog and Cat
            Dog dogSound = new Dog(); // Create a Dog object
            Cat catSound = new Cat(); // Create a Cat object

            // Call the MakeSound method for both objects
            dogSound.MakeSound(); // Dog makes a sound
            catSound.MakeSound(); // Cat makes a sound

            // Call the Move method for both objects
            dogSound.Move();
            catSound.Move(); 
        }
    }
}
