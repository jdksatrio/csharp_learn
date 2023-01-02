using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      int minLength = 8;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz";
      string digits = "1234567890";
      string specialChars = "!@#$%^&*(),.?-_";
      
      Console.WriteLine("Type your password:");
      string userPassword = Console.ReadLine();
      int score = 0;  
      if (userPassword.Length >= minLength){
        score = score + 1;
      }
      if (Tools.Contains(userPassword, uppercase)){
        score = score + 1;
      }
      if (Tools.Contains(userPassword,lowercase)){
        score = score + 1;
      }
      if (Tools.Contains(userPassword, digits)){
        score = score +1;
      }
      if (Tools.Contains(userPassword, specialChars)){
        score = score + 1;
      }
      Console.WriteLine($"The score of your password is: {score}");

      switch(score){
        case 5:
        case 4:
          Console.WriteLine("Your password is extremely strong!");
          break;
        case 3:
          Console.WriteLine("Your password is strong!");
          break;
        case 2:
          Console.WriteLine("Your password strength is medium!");
          break;
        case 1:
          Console.WriteLine("Your password is weak!");
          break;
        default:
          Console.WriteLine("Your password does not meet any of the standards");
          break;
      }
    }
  }
}
