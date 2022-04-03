using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsandGenerics
{
    class LinkedListEg
    {
        static void Main()
        {
            LinkedList<int> ll = new LinkedList<int>();
            ll.AddLast(100);
            ll.AddLast(90);
            ll.AddLast(80);
            ll.AddLast(70);
            ll.AddFirst(1);

            foreach(int n in ll)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("After inserting a node before 80");
            //inserting element
            LinkedListNode<int> node = ll.Find(80);
            ll.AddBefore(node, 2);
            ll.AddAfter(node, 3);
            foreach(var item in ll)
            {
                Console.WriteLine(item);
            }

            LinkedListNode<int> node1 = ll.Find(90);
            ll.AddBefore(node1, 1999);
            Console.WriteLine("Added data before 90");
            foreach (var item in ll)
            {
                Console.WriteLine(item);
            }
            //To remove the first element
            ll.RemoveFirst();
            Console.WriteLine("After Removing the First Element");
            foreach (var item in ll)
            {
                Console.WriteLine(item);
            }
            //To Remove the specified Node
            ll.Remove(node1);
            Console.WriteLine("After Removing the Node  holding 90");
            foreach (var item in ll)
            {
                Console.WriteLine(item);
            }
           
        }
    }
}
