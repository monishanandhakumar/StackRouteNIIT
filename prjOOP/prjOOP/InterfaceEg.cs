using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjOOP
{
    interface IScientificCalculator
    {
        int ADD(int x, int y);
        int Tan();
    }
    interface INormalCalculator
    {
        //All the methods inside the interface are public abstract
        int ADD(int a, int b);
        int Div(int a, int b);

    }
    class InterfaceEg: INormalCalculator, IScientificCalculator
    {

         int INormalCalculator.ADD(int a, int b)
            {
                return a + b;
            }

           int IScientificCalculator.ADD(int x, int y)
            {
                return x + y;
            }
     
     public  int ADD(int a, int b)
        {
            return a + b;
        }
        public int Div(int a, int b)
        {
            return a / b;
        }

      public int Tan()
        {
            return 1;
        }

        public static void Main()
        {
            //reference                        //ObjectCreated
            INormalCalculator normalCalculator = new InterfaceEg();
            Console.WriteLine(" INormalCalculator:{0}",normalCalculator.ADD(10, 30));
            Console.WriteLine( "Divide:{0}", normalCalculator.Div(9, 3)); 
            IScientificCalculator scientificCalculator = new InterfaceEg();
            Console.WriteLine(" IScientificCalculator:{0}", scientificCalculator.ADD(90, 30));
            Console.WriteLine("Tan:{0}", scientificCalculator.Tan());

            InterfaceEg interfaceEg = new InterfaceEg();
            interfaceEg.Div(9,3);
            interfaceEg.Tan();
            interfaceEg.ADD(8, 9);
        }
    }
}
