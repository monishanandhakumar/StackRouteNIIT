using System;
using System.Collections.Generic;
using System.Text;

namespace PrjProgrammingConstruction
{
    class TernarOperatorEg
    {
        public static void Main()
        {
            int number = 10;
            string result;
           bool iseven,ise;
            if(number %2==0)
            {
                iseven = true;
            }
            else
            {
                iseven = false;
            }

            ise = (number % 2 == 0) ? true : false;

            result= (number % 2 == 0) ? "number is even" : "number is odd";
            Console.WriteLine(iseven);
            Console.WriteLine(ise);
            Console.WriteLine(result);

        }
    }
}
