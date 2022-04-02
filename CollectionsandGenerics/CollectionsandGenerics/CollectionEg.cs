using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsandGenerics
{
    class CollectionEg
    {
        static void ArrayListEg()
        {
            ArrayList al = new ArrayList();
            al.Add(10); //boxing
            al.Add("Sai");
            al.Add(true);
            al.Add(78.9f);
            al.Add('o');
            al.Add(90);
            al.Add(89);
            al.Add("kalai");
            al.Add("hai");
            al.Add("Sai");

            Console.WriteLine("Capacity:{0}",al.Capacity);
            Console.WriteLine("count:{0}", al.Count);
            foreach (var item in al)
                Console.WriteLine(item); //unboxing
            //al.RemoveAt(3);
            al.Remove("Sai");
            Console.WriteLine("------------------------");
            Console.WriteLine("After remove");
            foreach (var item in al)
                Console.WriteLine(item);
            Console.WriteLine("------------------------");
            Console.WriteLine("After reverse");
            al.Reverse();
            foreach (var item in al)
                Console.WriteLine(item);
        }

        static void HashTableEg()
        {
            Hashtable ht = new Hashtable();
            ht.Add("j", "Java");
            ht.Add("d", "DS");
            ht.Add("a", "AI");
            ht.Add("n", ".Net");
            ht.Add(8, ".Net");

            ICollection keys = ht.Keys;

            foreach(var k in keys)
            {
                Console.WriteLine(k+" "+ ht[k]);
            }
            Console.WriteLine(ht.ContainsKey("n"));
        }

        static void SortedListEg()
        {
            SortedList st = new SortedList();
            st.Add(5, "Java");
            st.Add(2, "DS");
            st.Add(1, "AI");
            st.Add(8, ".Net");


            ICollection keys = st.Keys;

            Console.WriteLine("-------SortedList-------------");
            foreach (var k in keys)
            {
                Console.WriteLine(k + " " + st[k]);
            }
            Console.WriteLine(st.ContainsKey("n"));
        }

        //LIFO
        static void StackEg()
        {
            Stack stack = new Stack();
            stack.Push("io");
            stack.Push(78);
            stack.Push(90.78f);
            stack.Push('j');
            Console.WriteLine("No of Element in stack:{0}",stack.Count);
            Console.WriteLine("Stack contains:{0}", stack.Contains(78));
            foreach(var s in stack)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("After POP");
            stack.Pop();
            foreach (var s in stack)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Retuns the top element from the stack:{0}",stack.Peek()); 

        }
        //FIFO
        static void QueueEg()
        {
            Queue q=new Queue();
            q.Enqueue("90l");
            q.Enqueue(78);
            q.Enqueue('y');
            q.Enqueue(78.09f);

            foreach(var qu in q)
            {
                Console.WriteLine(qu);
            }
            Console.WriteLine("after Dequeue");
            q.Dequeue();
            foreach (var qu in q)
            {
                Console.WriteLine(qu);
            }

        }
        static void Main()
        {
            //ArrayListEg();
            // HashTableEg();
            // SortedListEg();
            // StackEg();
            QueueEg();

        }
    }
}
