using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!\nA bronze coin is worth 1 cent\nA silver coin is worth 5 cents\nA gold coin is worth 10 cents\n\nInsert the amount of cents you want to convert!\nAmount:");
      string amountString = Console.ReadLine();
      double amountDouble = Convert.ToDouble(amountString);
      Console.WriteLine($"{amountString} cents is equal to ...");
      double gold = 10;
      double silver = 5;
      double goldCoins = Math.Floor(amountDouble/gold);
      double remainder = amountDouble % gold;
      double silverCoins = Math.Floor(remainder/silver);
      remainder = remainder % silver;
      Console.WriteLine($"Gold coins: {goldCoins}");
      Console.WriteLine($"Silver coins: {silverCoins}");
      Console.WriteLine($"Bronze coins: {remainder}");

    }
  }
}
