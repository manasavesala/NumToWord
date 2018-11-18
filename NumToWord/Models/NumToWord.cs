using System;
using System.Linq;
using System.Collections.Generic;

namespace NumberToWord.Models
{
  public static class NumberToWord
  {
    static Dictionary<int, string> dic = new Dictionary<int, string>()
        {
          {1, "one"},
          {2, "two"},
          {3, "three"},
          {4, "four"},
          {5, "five"},
          {6, "six"},
          {7, "seven"},
          {8, "eight"},
          {9, "nine"},
          {10, "ten"},
          {11, "eleven"},
          {12, "twevel"},
          {13, "thirteen"},
          {14, "fourteen"},
          {15, "fifteen"},
          {16, "sixteen"},
          {17, "seventeen"},
          {18, "eighteen"},
          {19, "nineteen"},
          {20, "twenty"},
          {30, "thirty"},
          {40, "fourty"},
          {50, "fifty"},
          {60, "sixty"},
          {70, "seventy"},
          {80, "eighty"},
          {90, "ninety"},
          {100, "hundred"},
          {1000, "thousand"},

         };

    public static string convertNumToWord(int number)
    { 
      if (number > 1000) {
        return "Not supported";
      }

      string word = "";
      number = Math.Abs(number);
      int numberBackup = number;
      int length = number.ToString().Length;
      int[] array = new int[length];
      for (int i = 0; i < length; i++)
      {
        array[i] = number % 10;
        number /= 10;
      }

      number = numberBackup;
      
      Console.WriteLine($"number = {number}");
      if(number > 1000 && number < 9999)
      { 
        int thousandaPlace = array[3];
        int hundredsPlace = array[2];  
        int tensPlace = array[1] * 10;
        int onesPlace = array[0];
        string four = dic[thousandaPlace]+" "+dic[1000];
        string three = dic[hundredsPlace]+" "+ dic[100];
        string two = dic[tensPlace];
        string one = dic[onesPlace];
        word = four+" "+three +" "+two + " " + one ; 
      }else if(number > 100 && number < 1000)
      { 
        int hundredsPlace = array[2];  
        int tensPlace = array[1] * 10;
        int onesPlace = array[0];
        string three = dic[hundredsPlace]  +" "+ dic[100];
        string two = dic[tensPlace];
        string one = dic[onesPlace];
        word = three +" "+two + " " + one ; 
      }else if(number > 20 && number < 100)
      { 
        int hundredsPlace = array[2];  
        int tensPlace = array[1] * 10;
        int onesPlace = array[0];
        string two = dic[tensPlace];
        string one = dic[onesPlace];
        word = two + " " + one ; 
      }else if(number < 20)
      {
        word = dic[number];
      }

      return word;
    }

    public static void Main()
    {
      Console.WriteLine("Please enter a Number from 1-100:");
      int userInputNum = int.Parse(Console.ReadLine());
      Console.WriteLine(convertNumToWord(userInputNum));
    }

  }
}
