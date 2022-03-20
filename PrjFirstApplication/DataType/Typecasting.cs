using System;
using System.Collections.Generic;
using System.Text;

namespace DataType
{
    class Typecasting
    {
        public static void Main()
        {
            //Implicit conversion
            int a = 20, b = 30;
            float c;
            c=a+b;
            double d = c * a;
            Console.WriteLine("c is {0}",c);
            Console.WriteLine("d is {0}", d);

            //Explicit conversion

            int no =(int) c;

            //Impilict conversion
            object o = no;
            //Explicit conversion
            c= (float) o;
        }
    
    }
}
