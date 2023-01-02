using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      //inputs
      Console.WriteLine("Enter a name: ");
      string name = Console.ReadLine();
      Console.WriteLine("Enter an adjective: ");
      string adj1 = Console.ReadLine();
      Console.WriteLine("Enter the second adjective: ");
      string adj2 = Console.ReadLine();
      Console.WriteLine("Enter the third adjective: ");
      string adj3 = Console.ReadLine();
      Console.WriteLine("Enter a verb: ");
      string verb1 = Console.ReadLine();
      Console.WriteLine("Enter a noun: ");
      string noun1 = Console.ReadLine();
      Console.WriteLine("Enter another noun: ");
      string noun2 = Console.ReadLine();
      Console.WriteLine("Enter an animal: ");
      string animal = Console.ReadLine();
      Console.WriteLine("Enter a food: ");
      string food = Console.ReadLine();
      Console.WriteLine("Enter a fruit: ");
      string fruit = Console.ReadLine();
      Console.WriteLine("Enter a superhero: ");
      string hero = Console.ReadLine();
      Console.WriteLine("Enter a country: ");
      string country = Console.ReadLine();
      Console.WriteLine("Enter a dessert: ");
      string dessert = Console.ReadLine();
      Console.WriteLine("Enter a year: ");
      string year = Console.ReadLine();
      // The template for the story:

      string story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal} were protesting to keep {food} in stores. They began to {verb1} to the rhythm of the {noun1}, which made all the {fruit} very {adj3}. Concerned, {name} texted {hero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


      // Print the story:
      Console.WriteLine(story);

    }
  }
}
