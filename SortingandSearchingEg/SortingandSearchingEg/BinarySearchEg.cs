using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingandSearchingEg
{
    class BinarySearchEg
    {
      static int  BS()
        {

            int[] arr = { 90, 56, 78, 66, 45, 79, 99, 23 };
            int key = 79; //SearchElement

            Console.WriteLine("after sort Array:{0}");

            Console.WriteLine("Built in :{0}",Array.BinarySearch(arr, key)); 
            Array.Sort(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            int minNum = 0; //left element index
            int maxNum = arr.Length - 1; //right index

            Console.WriteLine("MinIndex:{0}", minNum);
            Console.WriteLine("MaxIndex:{0}", maxNum);
            while (minNum <= maxNum)
            {
                int mid = (minNum + maxNum) / 2;
                Console.WriteLine("Mid Index :{0}", mid);
                if (key == arr[mid])
                {

                    return mid;
                }
                else if (key < arr[mid])
                {
                    maxNum = mid - 1;
                    
                    
                }
                else
                {
                    minNum = mid + 1;
                   
                    
                }

            }
            return -1;

        }
        static void Main()
        {
            List<int> lt = new List<int>();
            lt.Add(67);
            lt.Add(27);
            lt.Add(88);
            lt.Add(23);
            lt.Add(10);

            Console.WriteLine("Binary Search in List:{0}", lt.BinarySearch(88)); 

            Console.WriteLine("Index of Search Element:{0}",BS()); 


        }
    }
}
