using System;

namespace Exercise_1
{
    // Define a class Circle
    class Circle
    {
        private double Radius; // Private field to store the radius of the circle

        // Constructor for the Circle class, initializes the radius
        public Circle(double radius)
        {
            Radius = radius;
        }

        // Method to calculate and return the area of the circle
        public double GetArea()
        {
            return Math.Round(Math.PI * Radius * Radius); // Calculate and round the area
            // Alternative: return Math.PI * Math.Pow(Radius, 2);
        }

        // Method to calculate and return the circumference of the circle
        public double GetCircumference()
        {
            return Math.Round(2 * Math.PI * Radius); // Calculate and round the circumference
        }
    }

    // Main program class
    class Program
    {
        // Entry point of the program
        static void Main(string[] args)
        {
            double radius = 5.5; // Define the radius of the circle

            Circle areaObj = new Circle(radius); // Create a Circle object with the given radius

            // Print the calculated area and circumference of the circle
            Console.WriteLine("The Area of Circle is " + areaObj.GetArea());
            Console.WriteLine("The Circumference of Circle is " + areaObj.GetCircumference());
        }
    }
}
