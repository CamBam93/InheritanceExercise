using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class


            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var bird1 = new Bird();
            bird1.Name = "penguin";
            bird1.Size = "medium";
            bird1.HasLegs = true;
            bird1.YearsOld = 3;
            bird1.CanFly = false;
            bird1.BeakType = "round";
            bird1.IsNocturnal = false;
            bird1.WingSpan = 4;

            Console.WriteLine($"The {bird1.Name} is a {bird1.Size} size bird that has {bird1.BeakType} with a wing span of {bird1.WingSpan}.");
            Console.WriteLine($"Can {bird1.Name} fly? {bird1.CanFly}. Is it nocturnal? {bird1.IsNocturnal}.");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var rep1 = new Reptile();
            rep1.Name = "snake";
            rep1.Size = "small";
            rep1.YearsOld = 1.5;
            rep1.HasLegs = false;
            rep1.ColdBlooded = true;
            rep1.HasScales = true;
            rep1.Environment = "humid";
            rep1.Defense = "camouflage";

            Console.WriteLine($"The {rep1.Name} is a {rep1.Size} size reptile that has {rep1.Defense} for defense and typicaly lives in a {rep1.Environment} environment.");
            Console.WriteLine($"Is the {rep1.Name} cold blooded? {rep1.ColdBlooded}. Does it have legs? {rep1.HasLegs}.");


        }
    }
}
