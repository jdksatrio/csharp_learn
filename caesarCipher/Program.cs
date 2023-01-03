using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      
      Console.Write("Type your secret message: ");
      string secretString = Console.ReadLine();
      char[] secretMessage = secretString.ToCharArray();
      char[] encryptedMessage = new char[secretMessage.Length];

      for (int i=0 ; i<secretMessage.Length; i++){
        char x = secretMessage[i];
        int pos = Array.IndexOf(alphabet,x);
        x = alphabet[(pos+3) % 26];
        encryptedMessage[i] = x;
      }
      string encryptedString = String.Join("",encryptedMessage);
      Console.Write($"\n\nYour encrypted message is: {encryptedString}\n");
    }
  }
}
