using System;
using System.Collections.Generic;
using System.Text;

namespace PrjProgrammingConstruction
{
    class StringEg
    {
        public static void Main()
        {
            string name;
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Name is {0}",name);
            //clone
            string username = (String)name.Clone();
            Console.WriteLine("name:{0}",name);
            Console.WriteLine("username:{0}", username);
            //compare
            string s1 = "Mango", s2 = "Orange",s3="Mango";

            Console.WriteLine(string.Compare(s1,s2)); //-1
            Console.WriteLine(string.Compare(s1, s3)); //0

            //concat
            string title = "Mr:";
            Console.WriteLine(string.Concat(title,name));

            //contains
            Console.WriteLine(s1.Contains("an"));//true
            Console.WriteLine(s1.Contains("ik"));//false
        }
    }
}
