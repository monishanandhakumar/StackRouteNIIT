using System;

namespace prjOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Organization org = new Organization();
            org.orgname = "NIIT";
            org.Displaydata();
        }
    }
}
