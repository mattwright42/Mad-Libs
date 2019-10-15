using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program asks the user for input and then creates a story from the input. 
      Author: Matt Wright
      */


      // Let the user know that the program is starting:
      Console.WriteLine("Let's get started on your MadLibs story!");

      // Give the Mad Lib a title:
      string title = "The Story of My Life";
      Console.WriteLine(title);

    // Define user input and variables:
    Console.Write("Enter a name: ");
    string name = Console.ReadLine();

            Console.Write("Enter an adjective: ");
            string adj1 = Console.ReadLine();
            Console.Write("Enter another adjective: ");
            string adj2 = Console.ReadLine();
            Console.Write("Enter one more adjective: ");
            string adj3 = Console.ReadLine();
            Console.Write("Enter a verb: ");
            string verb = Console.ReadLine();
            Console.Write("Enter a noun: ");
            string noun1 = Console.ReadLine();
            Console.Write("Enter another noun: ");
            string noun2 = Console.ReadLine();
            Console.Write("Enter your favorite animal: ");
            string animal = Console.ReadLine();
            Console.Write("Enter your favorite food: ");
            string food = Console.ReadLine();
            Console.Write("Enter your favorite fruit: ");
            string fruit = Console.ReadLine();
            Console.Write("Enter your favorite superhero: ");
            string superhero = Console.ReadLine();
            Console.Write("Enter your favorite country: ");
            string country = Console.ReadLine();
            Console.Write("Enter your favorite dessert: ");
            string dessert = Console.ReadLine();
            Console.Write("Enter your favorite year: ");
            string year = Console.ReadLine();



            // The template for the story:

            string story = "This morning _ woke up feeling _. 'It is going to be a _ day!' Outside, a bunch of _s were protesting to keep _ in stores. They began to _ to the rhythm of the _, which made all the _s very _. Concerned, _ texted _, who flew _ to _ and dropped _ in a puddle of frozen _. _ woke up in the year _, in a world where _s ruled the world.";


      // Print the story:

    }
  }
}
