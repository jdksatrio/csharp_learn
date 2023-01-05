using System;

namespace DatingProfile
{
  class Profile
  {
    string name;
    int age;
    string city;
    string country;
    string pronouns;
    string[] hobbies;

    public Profile(string name, int age, string city = "n/a", string country = "n/a", string pronouns = "they/them"){
      this.name = name;
      this.age = age;
      this.city = city;
      this.country = country;
      this.pronouns = pronouns;
      this.hobbies = new string[0];
    }

    public string ViewProfile(){
      string bio = $"Name: {name}\nAge: {age}\nCity: {city}\nCountry: {country}\nPronouns: {pronouns}";

      if (hobbies.Length > 0){
        bio += "\nHobbies: \n";
      foreach (string hobby in hobbies){
        bio += $"- {hobby}\n";
      }
    }
    return bio;
    }
    public void SetHobbies(string[] hobbies){
      this.hobbies = hobbies;
    }
  } 
}
