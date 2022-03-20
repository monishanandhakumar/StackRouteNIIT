using System;
using System.Collections.Generic;
using System.Text;

namespace DataType
{
    class ArthimeticOperator
    {
        static void Main()
        {
            int no, add, sub, mul, mod, div;
            Console.WriteLine("Enter the input");
            no = Convert.ToInt32(Console.ReadLine());
            add = no + no;
            Console.WriteLine("add is {0}",add);
            sub = add - no;
            Console.WriteLine("sub is {0}", sub);
            /* or
             *  Console.WriteLine("sub is {0}", add-no);
             * 
             * */
            int a = 30, b = 40 , c;
            c = a * b;
            Console.WriteLine("mul is {0} * {1} ={2}",a,b,c );

            


        }
    }
}
