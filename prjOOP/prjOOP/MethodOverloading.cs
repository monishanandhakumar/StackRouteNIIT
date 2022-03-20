using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjOOP
{
    class MethodOverloading
    {
         int  Area(int a)
        {
            return a * a;
        }

        float Area(float c)
        {
            return c * c;
        }
        static int Area(int l,int b)
        {
            return l* b;
        }


        static void Main()
        {
            MethodOverloading mobj = new MethodOverloading();
            Console.WriteLine("Area of Circle:{0}", mobj.Area(5));
            Console.WriteLine("Area of rectangle:{0}", Area(5,8));
            Console.WriteLine("Area :{0}", mobj.Area(5.0f));
        }
    }
}
