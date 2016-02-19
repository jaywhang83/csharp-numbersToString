using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace NumberToStringNS
{
  public class NumberToString
  {
    string placeHolder = "";
    Dictionary <int, string> below20= new Dictionary <int, string> {
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
                                      {12, "twelve"},
                                      {13, "thirteen"},
                                      {14, "fourteen"},
                                      {15, "fifteen"},
                                      {16, "sixteen"},
                                      {17, "seventeen"},
                                      {18, "eighteen"},
                                      {19, "nineteen"}


    };
    Dictionary <int, string> between20And99= new Dictionary <int, string> {
                                      {2, "twenty"},
                                      {3, "thirty"},
                                      {4, "fourty"},
                                      {5, "fifty"},
                                      {6, "sixty"},
                                      {7, "seventy"},
                                      {8, "eighty"},
                                      {9, "ninty"}
    };

    Dictionary <int, string> below20= new Dictionary <int, string> {
                                      {1, "one"},
                                      {2, "two"},
                                      {3, "three"},
                                      {4, "four"},
                                      {5, "five"},
                                      {6, "six"},
                                      {7, "seven"},
                                      {8, "eight"},
                                      {9, "nine"},
    };
    public string StringGenerator(int number)
    {

      if (number >= 100 && number < 1000)
      {
        placeHolder += StringGeneratorBelow20(number)
      }

      else if(number >=20 && number < 100)
      {
        placeHolder += StringGeneratorBelow100(number);
      }
      else if(number < 20)
      {
        placeHolder += StringGeneratorBelow20(number);
      }

      return placeHolder;
    }

    public string StringGeneratorBelow100(int number)
    {
      string holder = "";
      foreach(var key in between20And99)
      {
        if ((number / 10) == key.Key)
        {
          holder += key.Value;
          Console.WriteLine(key.Value);
          if (number % 10 > 0)
          {
            holder = holder + " " + StringGeneratorBelow20(number % 10);
          }
        }
      }
      Console.WriteLine(holder);
      return holder;
    }

    public string StringGeneratorBelow20(int number)
    {
      foreach(var key in below20)
      {
        if(number == key.Key)
        {
          Console.WriteLine(key.Value);
        return key.Value;
        }
      }
      return "once More";
    }

  }
}


// int n = 23
// csharp> n %= 20;
// csharp> n
// 3
