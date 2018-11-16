using System;
using System.Linq;
using System.Collections.Generic;

namespace NumberToWord.Models
{
  public static class NumberToWord
  {
    public static void convertNumToWord(int number)
    {
      Dictionary<int, string> wordDictionary = new Dictionary<int, string>();

      wordDictionary.Add(1, "one");
      wordDictionary.Add(2, "two");
      wordDictionary.Add(3, "three");
      wordDictionary.Add(4, "four");
      wordDictionary.Add(5, "five");
      wordDictionary.Add(6, "six");
      wordDictionary.Add(7, "seven");
      wordDictionary.Add(8, "eight");
      wordDictionary.Add(9, "nine");
      wordDictionary.Add(10, "ten");
      // wordDictionary.Add(20, "twenty");
      // wordDictionary.Add(30, "thirty");
      // wordDictionary.Add(40, "fourty");
      // wordDictionary.Add(50, "fifty");
      // wordDictionary.Add(60, "sixty");
      // wordDictionary.Add(70, "seventy");
      // wordDictionary.Add(80, "eighty");
      // wordDictionary.Add(90, "ninety");
      // wordDictionary.Add(100, "hundred");

        if(wordDictionary.ContainsKey(number)){
          string word = wordDictionary[number];
          Console.WriteLine(word);
        }


    }



    public static void Main()
    {
      Console.WriteLine("Please enter a Number from 1-10:");
      int userInputNum = int.Parse(Console.ReadLine());
      convertNumToWord(userInputNum);

    }

  }
}
