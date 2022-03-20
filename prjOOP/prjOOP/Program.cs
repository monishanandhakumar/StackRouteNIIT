using System;

namespace prjOOP
{
    class Person
    {
        string pname="hari";
        string paddress="chennai";
        float height=5.7f;
        int[] mark = { 90, 78, 67 };

        internal int CalculateAvg()
        {
            int avg,sum=0;
            foreach(int m in mark)
            {
                sum = sum + m;
            }
            avg = sum / 3;
            return avg;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Console.WriteLine(p.CalculateAvg()); 
            Console.WriteLine("Hello World!");
           /* Organization org = new Organization();
            org.orgname = "NIIT";
            org.Displaydata();*/
        }
    }
}
