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

        static void SortedList()
        {
            SortedList<string, string> sl = new SortedList<string, string>();
            sl.Add("k", "Kite");
            sl.Add("a", "All");
            sl.Add("c", "Currency");

            foreach(KeyValuePair<string,string> kp in sl)
            {
                Console.WriteLine(kp.Key+" "+kp.Value);
            }
        }
        //FILO
        static void StackEg()
        {
            Stack<int> st = new Stack<int>();
            st.Push(90);
            st.Push(89);
            st.Push(67);
            st.Push(56);

            foreach(int o in st)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("---------------------------");
            st.Pop();
            Console.WriteLine("Peek is:{0}",st.Peek()); 

        }

        static void QueueEg()
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue("Java");
            q.Enqueue("ÄI");
            q.Enqueue("TOC");
            q.Enqueue("OOAD");

            foreach(string s in q)
            {
                Console.WriteLine(s);
            }

            q.Dequeue();
            Console.WriteLine("-----------After Dequeue---------");
            foreach (string s in q)
            {
                Console.WriteLine(s);
            }

        }
        static void Main()
        {
            // ListEg(); 
            // DictionaryEg();
            // SortedList();
          //  StackEg();
            QueueEg(); 
        }
    }
}
