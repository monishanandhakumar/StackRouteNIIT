using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjOOP
{

    class Demo
    {

        internal void Print(int num1,int num2,out int add,out int mul)
        {
             add = num1 + num2;
            mul = num1 * num2;

            
        }

        internal void CalculateMark(int rollno ,string name,params int[] marks)
        {
            int total=0;
            foreach (int m  in marks)
            {
                total = total + m;
            }
            Console.WriteLine("rollno:{0}||name:{1}||total:{2}",rollno,name,total);
        }

    }
    class ParamsOutEg
    {
        static void Main()
        {
            int addition = 0,multiplication=0;

            Demo demo = new Demo();
            demo.Print(8, 7, out addition, out multiplication);
            Console.WriteLine("Addition:{0}||Multiplication:{1}",addition,multiplication);
            int[] marks = { 90, 78, 67, 56 };
            demo.CalculateMark(1001, "Sasi",marks);

          // demo.CalculateMark(100, 90, 89, 67, 90, 67,23);


        }
    }
}
