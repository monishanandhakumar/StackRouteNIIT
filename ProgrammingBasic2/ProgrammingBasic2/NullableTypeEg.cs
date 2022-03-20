using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingBasic2
{
    class NullableTypeEg
    {

        public static void Main()
        {
            // int age=null; //non-nullable valuetype
            int? age = 45;//Value-nullable type
            string? name=null;//Reference type
            int? a;
          /*  if(age!=null)
            {
                a = age;
            }
            else
            {
                a = 0;
            }*/
            //a=(age!=null)?age:0;
            Console.WriteLine("Age is :{0}", (age != null) ? age : 0);
            Console.WriteLine("name is :{0}",name);
        }
    }
}
