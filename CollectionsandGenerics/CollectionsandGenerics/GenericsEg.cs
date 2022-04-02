using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsandGenerics
{
    class GenericsEg
    {
        static void ListEg()
        {
            var fruits = new List<string>();
            fruits.Add("Mango");
            fruits.Add("Orange");
            fruits.Add("Apple");
            fruits.Add("Banana");

            foreach(var item in fruits)
            {
                Console.WriteLine(item);
            }
            fruits.Sort();
            Console.WriteLine("--------after sort-------------");

            foreach (var item in fruits)
            {
                Console.WriteLine(item);
            }

        }

        static void DictionaryEg()
        {
            Dictionary<int, string> dt = new Dictionary<int,string>();
            dt.Add(10, "Ram");
            dt.Add(20, "Ravi");
            dt.Add(30, "Arul");
            dt.Add(40, "Siva");

            foreach(KeyValuePair<int,string> kp in dt)
            {
                Console.WriteLine(kp.Key+" "+kp.Value );
            }

        }

        static void Main()
        {
            // ListEg(); 
            DictionaryEg();
        }
    }
}
