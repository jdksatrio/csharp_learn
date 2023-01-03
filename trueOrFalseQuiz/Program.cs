using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      // Do not edit these lines
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      // Type your code below
      string[] questions = {"Eggplant is a vegetable.", "Eggplants are a species in the nightshade family.","Eggplants are a type of Berry","Eggplants were once used to dye teeth for fashion","Eggplants are reported to have the highest level of nicotine of any other vegetable"};
      bool[] answers = {false,true,true,true,true};
      bool[] responses = new bool[answers.Length];

      if (questions.Length != answers.Length){
        Console.WriteLine("WARNING! Unequal amount of questions and answers!");
      }
      
      int askingIndex = 0;

      foreach (string question in questions){
        string input;
        bool isBool;
        bool inputBool;

        Console.WriteLine(question);
        Console.WriteLine("True or False?");
        input = Console.ReadLine();
        isBool = Boolean.TryParse(input, out inputBool);

        while (isBool == false){
          Console.WriteLine("Please respond with 'true or 'false.");
          input = Console.ReadLine();
          isBool = Boolean.TryParse(input, out inputBool);
        }
        responses[askingIndex] = inputBool;
        askingIndex += 1;
      }
        int scoringIndex = 0;
        int score = 0;

        foreach (bool answer in answers){
          bool ans = responses[scoringIndex];
          Console.WriteLine($"Input: {responses[scoringIndex]} | Answer: {answers[scoringIndex]}");
          scoringIndex++;
          if (answer == ans){
            score += 1;
          }
        }
        Console.WriteLine($"You got {score} out of {answers.Length} correct!");
    }
  }
}
