using System;
using System.Collections.Generic;
using System.Text;

namespace DataType
{
    class RelationalOperator
    {
        static void Main()
        {
            bool result;
            int a = 10, b = 40;
            result = (a == b);
            Console.WriteLine("Equal to :{0}" ,result);
            result = (a > b);
            Console.WriteLine(" a greater than b:{0}", result);
            result = (a < b);
            Console.WriteLine("a less than b :{0}", result);
            result = (a <= b);
            Console.WriteLine("a less than equal to b :{0}", result);
            result = (a != b);
            Console.WriteLine("a not equal to b :{0}", result);
        }
    }
}
