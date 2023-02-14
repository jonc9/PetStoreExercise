using System;
//using System.Collections.Generic;
using PetStoreProduct;

namespace JonCundiffPetStoreClassExercise
{
    internal class Program
    {
        //string userInput = "";

        //List<CatFood> catfood = new List<CatFood>();
        //List<DogLeash> dogleash = new List<DogLeash>();
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 to add a product");
            Console.WriteLine("Type 'exit' to quit");
            string userInput = Console.ReadLine();

            while (userInput.ToLower() != "exit") // this asks the intitial question of what the user wants to choose
            {
                //Console.WriteLine("Press 1 to add a product");
                //Console.WriteLine("Type 'exit' to quit");
                //userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    Console.WriteLine("Cat food or dog leash?");//TRYING TO FIGURE OUT WHY THIS WON'T FUCKING WORK. I NEED INPUT NOT ERROR!
                    userInput = Console.ReadLine();
                }
                    if (userInput == "cat food")
                    {
                        CatFood catfood = new CatFood()
                        {
                            Name = userInput,
                            Price = decimal.Parse(userInput),
                            Quantity = int.Parse(userInput),
                            Description = userInput,
                            WeightPounds = int.Parse(userInput),
                            KittenFood = bool.Parse(userInput),
                        };
                        Console.WriteLine(catfood);
                    }
                
                    //if (userInput == "1") // this asks the user what they want
                    //{
                    //    Console.WriteLine("What would you like to add? Cat food or a dog leash? Or would you like More Information?");
                    //    userInput = Console.ReadLine();
                    //}
                    //if (userInput == "cat food") // When cat food is chosen I want to show the Properties from the CatFood class
                    //{
                    //    Console.WriteLine("Okay. Cat food it is!");
                    //    Console.WriteLine("Enter your cat food below:");
                    //    userInput = Console.ReadLine();
                    //    CatFood catfood = new CatFood // trying to figure out how to get catfood to ask for input correctly without error.
                    //    {
                    //        Name = "Nature's Valley", // need to put console.writeline but may have to use {} between each line below
                    //        Price = decimal.Parse(userInput),
                    //        Quantity = int.Parse(userInput),
                    //        Description = userInput,
                    //        WeightPounds = int.Parse(userInput),
                    //        KittenFood = bool.Parse(userInput),
                    //    };

                    /*CatFood.Add(catfood);
                    Console.WriteLine("Type 'exit' to quit");*/

                    //}
                    //string userInput = Console.ReadLine();
                    /*if (userInput == "exit") // an exit test
                    {
                        Console.WriteLine("Okay bye");
                        Environment.Exit(0);
                    }
                    else // just some placeholder test stuff 
                    {
                        Console.WriteLine("huh? Try again, please.");
                    }*/
                
            }
        }
    }
}