using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingandSearchingEg
{
    class InsertionSortEg
    {
        static void Main()
        {
            int[] arr = { 7, 2, 1, 5, 8 };
            int j, temp;
            Console.WriteLine("InsertionSort:{7, 2, 1, 5, 8}");
            for(int i=1;i<arr.Length;i++)
            {
                Console.WriteLine("Iteration :{0}",i);
                temp = arr[i];
                Console.WriteLine("temp:{0}",temp);
                j = i - 1;
                Console.WriteLine("j:{0}", j);
                Console.WriteLine("while ({0}>=0 && {1}>{2} )",j,arr[j],temp);
                while (j>=0 && arr[j]>temp )
                {

                    arr[j + 1] = arr[j];
                    Console.WriteLine("arr[j + 1]= arr[j]: arr[{0} + 1]=arr[{1}]",j,j);
                    j--;
                    Console.WriteLine("j--:{0}",j);
                }
                arr[j + 1] = temp;
                Console.WriteLine("arr[j + 1] = temp: arr[{0} + 1] ={1};",j,temp);
                Console.WriteLine("---------------------------------");
            }

            Console.WriteLine("------------AfterSort----------------");
            foreach(var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
