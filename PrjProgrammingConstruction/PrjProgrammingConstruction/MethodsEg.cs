using System;
using System.Collections.Generic;
using System.Text;

namespace PrjProgrammingConstruction
{
    class MethodsEg
    {
        void Add(int a,int b)
        {
            int c = a + b;
            Console.WriteLine("Add:{0}",c);
        }

        int Areaofcircle(int a)
        {
            return a * a;
        }

        static void displayname(string name)
        {
            Console.WriteLine("Name is :{0}",name);
        }

   public  int  GetOverAllScore()
        {
            int Avg = (90 + 89 + 78) / 3;
            return Avg;

        }
        static void Main()
        {
            MethodsEg methodsEg = new MethodsEg();
            Console.WriteLine("Enter the value of a and b");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            methodsEg.Add(a, b);
            int r = methodsEg.Areaofcircle(6);
            Console.WriteLine(r);
            MethodsEg.displayname("Sai");
            Console.WriteLine("Get over all score:{0}", methodsEg.GetOverAllScore());
        }
    }
}
