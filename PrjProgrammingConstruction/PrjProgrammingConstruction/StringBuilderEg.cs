using System;
using System.Collections.Generic;
using System.Text;

namespace PrjProgrammingConstruction
{
    class StringBuilderEg
    {
        public static void Main()
        {
            StringBuilder s = new StringBuilder("goodnoon");
            s = new StringBuilder("Good");
            Console.WriteLine("capacity: "+s.Capacity);
            Console.WriteLine("length: " + s.Length);
            s.Append("All!");
            Console.WriteLine(s);
            s.Insert(4, "After");
            Console.WriteLine(s);
            s.Remove(4, 5);
            Console.WriteLine(s);
            s.Replace("goodnoon", "GOODNOON");
            Console.WriteLine(s);

            Console.WriteLine("enter name , Age ,Marks");
            string uname = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());
            float marks = float.Parse(Console.ReadLine());
            float a = 40.9f, b = 30.12f, c; double d=23000.00;
            c = a + b;
            Console.WriteLine(d);
            Console.WriteLine("Name:{0} || Age:{1} || Marks:{2}",uname,age,marks);

        }
    }
}
