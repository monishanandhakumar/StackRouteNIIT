using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PrjProgrammingConstruction
{
    class RegularExpressionEg
    {
      public  static void Main()
        {
            //char only
            string input = "Abc123";
            bool result;
            Regex r = new Regex("^[a-zA-z]+$");
            result= r.IsMatch(input);
            Console.WriteLine(result);
            //digitonly
            string input1 = "123";
            Regex r1 = new Regex("^[0-9]+$");
            result = r1.IsMatch(input1);
            Console.WriteLine("DigitOnly:{0}",result);

        }
    }
}
