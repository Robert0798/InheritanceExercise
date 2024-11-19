using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

           var myBird = new Bird();
           {
               myBird.IsAlive = true;
               myBird.CanFly = true;
               myBird.IsTheWord = true;
               myBird.WingColor = "Red";
               myBird.DoMigrate = true;
           }
           
           var myReptile = new Reptile();
           {
               myReptile.IsAlive = true;
               myReptile.Habitat = "Desert";
               myReptile.IsScaly = true;
               myReptile.EatPizza = true;
               myReptile.IsColdBlooded = true;
           }
           
           var myAnimals = new Animal[] {myBird, myReptile };

           foreach (var animal in myAnimals)
           {
               Console.WriteLine($"Alive:{animal.IsAlive}");
               Console.WriteLine($"Age:{animal.Age} years old");
               Console.WriteLine($"It has{animal.LegCount} legs");
               Console.WriteLine($"It lives by {animal.LandSeaAir}");
               Console.WriteLine("");
           }



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
