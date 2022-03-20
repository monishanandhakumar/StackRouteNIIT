using System;
using System.Collections.Generic;
using System.Text;

namespace DataType
{
    class SimpleInterest
    {
        static void Main()
        {
            int principal, months;
            float rate;
            double si;
            Console.WriteLine("Enter principal amount");
            principal = Convert.ToInt32(Console.ReadLine());//converting string to int
            Console.WriteLine("Enter Months");
           months= Convert.ToInt32(Console.ReadLine());//converting string to int
            Console.WriteLine("Enter rate of interest");
            rate= float.Parse(Console.ReadLine());//Converting string to float

            si = (principal * months * rate) / 100;
            Console.WriteLine("SI:{0}",si);


        }
    }
}
