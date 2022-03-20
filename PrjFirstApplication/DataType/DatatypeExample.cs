using System;
using System.Collections.Generic;
using System.Text;

namespace DataType
{
    class DatatypeExample
    {
       public static void Main()
        {
            Console.WriteLine("Enter your Name");
            string name = Console.ReadLine(); //reference type
            Console.WriteLine("Your Name is :{0}",name);
            //----------------------------------------------------
            //  int num1 = 10, num2 = 20;
            int num1, num2;//value type
            Console.WriteLine("Enter the value of num1");
           num1= Convert.ToInt32(Console.ReadLine());//type conversion
            Console.WriteLine("Enter the value of num2");
            num2 = Convert.ToInt32(Console.ReadLine());//type conversion
            int result;
            result = num1 + num2;
            //Print in output window
            Console.WriteLine("result:{0}", result);
        }
    }
}
