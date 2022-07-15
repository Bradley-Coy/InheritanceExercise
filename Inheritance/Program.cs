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

            Animal myAnimal = new Animal();
            Console.WriteLine($"All animals have {myAnimal.sensoryOrgans}, {myAnimal.abilityToMove}, {myAnimal.internalDigestion}, and {myAnimal.sexualReproduction} ");

            Bird myBird = new Bird();
            Console.WriteLine($"All birds have {myBird.haveWings}, {myBird.haveFeathers}, {myBird.warmBlood}, and {myBird.laysEggs}.");

            var myReptile1 = new Reptile();

            // Console.WriteLine(myReptile);

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
