using System;

namespace MagicalInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      //straight up constructing storm
      Storm StormOne = new Storm("wind",false,"Zul'rajas");
      Console.WriteLine(StormOne.Announce() + "\n");

      //using Pupil class
      Pupil pupilOne = new Pupil("Mezil-kree");
      Storm pOneStorm = pupilOne.CastWindStorm();
      Console.WriteLine(pOneStorm.Announce() + "\n");

      //Mage class
      Mage mOne = new Mage("Gul'dan");
      Storm mOneStorm = mOne.CastRainStorm();
      Console.WriteLine(mOneStorm.Announce() + "\n");

      //Archmage class
      Archmage aOne = new Archmage("Nielas Aran");
      Storm aOneStorm = aOne.CastRainStorm();
      Storm aOneStorm2 = aOne.CastLightningStorm();
      Console.WriteLine(aOneStorm.Announce()+"\n"+aOneStorm2.Announce());          
    }
  }
}
