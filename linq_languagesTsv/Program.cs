using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProgrammingLanguages
{
  class Program
  {
    static void Main()
    {
      List<Language> languages = File.ReadAllLines("./languages.tsv")
        .Skip(1)
        .Select(line => Language.FromTsv(line))
        .ToList();

        //Print all string with year, name, and chief dev
        /*var query1 = from j in languages
          select $"{j.Year}, {j.Name}, {j.ChiefDeveloper}"; 

        foreach (var i in query1){
          Console.WriteLine(i);*/

      //Query C# from the list and stringfy
      /*var csharp = from j in languages
        where j.Name.Contains("C#")
        select j.Prettify();

      foreach (string j in csharp){
      Console.WriteLine(j);
      }*/

      //Query "Microsoft" as the dev
      /*var microsoft = from j in languages
        where j.ChiefDeveloper.Contains("Microsoft")
        select j.Prettify();

      foreach (string j in microsoft){
      Console.WriteLine(j);
    }*/

      //Select the languages invented between 2005 and 1995
      /*var yearRange = from j in languages
        where j.Year > 1995 && j.Year < 2005
        select $"{j.Name} was invented in {j.Year}";

      foreach (string j in yearRange){
      Console.WriteLine(j);
      }*/

   //method call to print them all   
   Language.PrettyPrintAll(languages);
      
   } 
  }
}
