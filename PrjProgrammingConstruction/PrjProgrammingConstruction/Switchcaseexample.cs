using System;
using System.Collections.Generic;
using System.Text;

namespace PrjProgrammingConstruction
{
    class Switchcaseexample
    {
        public static void Main()
        {
            int a = 90, b = 56,result;
            //  Console.WriteLine("Enter the Operation to be performed 1:Addition  2:Subtraction 3:Multiplication");
            // int op=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Operation to be performed +:Addition  -:Subtraction *:Multiplication");
            char op = Convert.ToChar( Console.ReadLine());
            switch (op)
            {
                case '+':
                    {
                        Console.WriteLine("Addition");
                        result = a + b;
                        Console.WriteLine("Addition result is :{0}",result);
                        break;
                    }
                case '-':
                    {
                        Console.WriteLine("Subtraction");
                        result = a - b;
                        Console.WriteLine("Subtraction result is :{0}", result);
                        break;
                    }
                case '*':
                    {
                        Console.WriteLine("Multiplication");
                        result = a * b;
                        Console.WriteLine("Multiplication result is :{0}", result);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("No Match found");
                        break;
                    }

            }
                
        }
    }
}
