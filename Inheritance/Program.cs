using System;
using System.IO.IsolatedStorage;

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

            var myBird = new Bird();
            myBird.WingColor = "red";
            myBird.CanFly = true;
            myBird.DoMigrate = true;
            myBird.BeakLength = 4;



            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var myReptile = new Reptile()
            {
                IsColdBlooded = true,
                IsScaly = true,
                Habitat = "Desert",
                CanGrowTail = true 
               
            };
            

        }
    }
}
