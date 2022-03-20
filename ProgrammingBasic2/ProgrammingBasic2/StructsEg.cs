using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingBasic2
{
   public struct Rectangle
    {
        public int width, height;
      public void Display()
        {
            Console.WriteLine("rec area is:{0}",width*height);
        }
    }
    class StructsEg
    {
        public static void Main()
        {
            Rectangle rec = new Rectangle();
            rec.width = 20;
            rec.height = 15;
            rec.Display();
            Console.WriteLine("area of rectangle:{0}", rec.width * rec.height);
        }
        
    }
}
