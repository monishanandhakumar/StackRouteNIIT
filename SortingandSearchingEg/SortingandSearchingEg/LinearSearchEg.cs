using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingandSearchingEg
{
    class LinearSearchEg
    {
        public static void Main()
        {
            int[] arr = {90,56,78,66,45,79,99,23 };
            Console.WriteLine("Enter the search list from the following list {90,56,78,66,45,79,99,23 }");
            int Searchelement = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Using Built -in Method");
            Console.WriteLine(Array.Exists(arr, data => data == Searchelement));
            for (int i=0;i<arr.Length;i++)
            {
                if(arr[i]==Searchelement)
                {
                    Console.WriteLine("Search Element{0} found in {1} position",Searchelement,i);
                    return;
                }
            }
            Console.WriteLine("Search Element Not Found!!");
           

        }
    }
}
