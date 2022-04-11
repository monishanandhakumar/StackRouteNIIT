using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingandSearchingEg
{
    class BubbleSort
    {
        static void Main()
        {
            int[] arr = { 7, 2, 1, 5, 8 };

            Console.WriteLine("Length of an Array:{0}",arr.Length);
            for(int i=0;i<arr.Length-1;i++)
            {
                for(int j=0;j<arr.Length-i-1; j++)
                {
                    //swapping
                    if(arr[j]>arr[j+1])
                    {
                        int temp;
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }

                }
            }

            //Print the Sorted Element

            foreach(var item in arr)
            {
                Console.WriteLine(item);
            }

        }
    }
}
