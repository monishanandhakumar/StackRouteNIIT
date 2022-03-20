using System;
using System.Collections.Generic;
using System.Text;

namespace PrjProgrammingConstruction
{
    class ArrayExample
    {
        void Singledimension()
        {
            string[] fruits = new string[3];
            for(int i=0;i<fruits.Length;i++)
            {
                Console.WriteLine("Enter the fruit");
                fruits[i] = Console.ReadLine();
            }
            Console.WriteLine("data from array");
           // for (int i = 0; i < fruits.Length; i++)
             foreach (var f in fruits )
            {
                Console.WriteLine(f);
            }

            int[] marks = { 90, 78, 89, 56 };

            foreach(int m in marks)
            {
                Console.WriteLine("Mark is :{0}",m);
            }
        }

        void Multidimensional()
        {
            //   int[,] arr = new int[2, 2] { { 10,20},{ 30,40} };
            int[,] arr = new int[2, 2];
            arr[0, 0] = 10;
            arr[0, 1] = 20;
            arr[1, 0] = 30;
            arr[1, 1] = 40;

            for (int i=0;i<2;i++)
            {
                for (int j = 0; j< 2; j++)
                {
                    Console.WriteLine("a[{0},{1}]={2}",i,j,arr[i,j]);
                }
            }
        }

        void Jaggedarray()
        {
            int[][] jagarr = new int[2][];
            jagarr[0] = new int[] { 10, 20 };
            jagarr[1] = new int[] { 11,12,13 };

            for(int row=0; row < jagarr.Length; row++)
            {
                for(int k=0;k<jagarr[row].Length;k++)
                {
                    Console.WriteLine(row + ":"+jagarr[row][k]);
                }
               
            }

        }
        static void Main()
        {
            ArrayExample arrayExample = new ArrayExample();
            //  arrayExample.Singledimension();
            //   arrayExample.Multidimensional();
            arrayExample.Jaggedarray();

        }
    }
}
