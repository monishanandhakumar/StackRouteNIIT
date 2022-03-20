using System;
using System.Collections.Generic;
using System.Text;

namespace PrjProgrammingConstruction
{
    class IfElseExample
    {
        public static void Main()
        {
            int a = 89, b = 90, c = 45;
            if(a> b && a>c)
            {
                Console.WriteLine("A is greater :{0}",a);
            }
            else if(b> c)
            {
                Console.WriteLine("B is greater:{0}",b);
            }
            else
            {
                Console.WriteLine("C is greater:{0},",c);
            }

            //Nested if -else

           
            int age = 0;
            if(age !=0)
            {
                if(age>18)
                {
                    Console.WriteLine("Eligible to vote");
                }

                else
                {
                    Console.WriteLine("Your are not eligible to vote");
                }
            }

            else
            {
                Console.WriteLine("Age cant be null");
            }

        }
    }
}
