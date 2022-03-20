using System;
using System.Collections.Generic;
using System.Text;

namespace DataType
{
    class LogicalOperator
    {
        static void Main()
        {
            bool a = true, b = true, result;
            result = a && b;
            Console.WriteLine("a && b:{0}",result);
            result = a || b;
            Console.WriteLine("a || b:{0}", result);
            result = !a;
            Console.WriteLine("!a:{0}", result);
        }
    }
}
