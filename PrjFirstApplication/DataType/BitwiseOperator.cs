using System;
using System.Collections.Generic;
using System.Text;

namespace DataType
{
    class BitwiseOperator
    {
        static void Main()
        {
            int a = 14, b = 11,result ,c=42;
            result = a | b;
            Console.WriteLine("Bitwise a|b:{0}",result);
            result = a & b;
            Console.WriteLine("Bitwise a&b:{0}", result);
            result = a ^ b;
            Console.WriteLine("Bitwise a^b:{0}", result);
            result = ~a;
            Console.WriteLine("Bitwise ~a:{0}", result);
            result = c << 2;
            Console.WriteLine("leftshift :2 :{0}", result);

        }
    }
}
