using System;
using System.Collections.Generic;
using System.Text;

namespace PrjProgrammingConstruction
{
    class LoopEg
    {
        public static void Main()
        {
            int number = 2, n = 10,result;

            for(int i=1;i<=n;i++)
            {
               result= i * 2;
                Console.WriteLine("{0}*{1}={2}",i,number,result);
            }

            //while
            int j = 1;
            Console.WriteLine("While");
            while(j<=n)
            {
                result = j * number;
                Console.WriteLine("{0}*{1}={2}", j, number, result);
                j++;

            }
            
        }
    }
}
