using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjOOP
{
  abstract class AICTE
    {
        int totalcoll = 100;
      abstract public void GradeCalculator();

        //non-abstract method
        internal void TotalCollgeRegisterd()
        {
            Console.WriteLine(totalcoll);
        }
    }

    class MIT : AICTE
    {
        public override void GradeCalculator()
        {
            int assignmentmark =100, semmark= 500,totalsubject=6;
            double grade;
            Console.WriteLine("MIT GradeCalculator");

        }
    }
    class SRM : AICTE
    {
        public override void GradeCalculator()
        {
            int  semmark = 500, totalsubject = 6;
            double grade;
            Console.WriteLine("SRM GradeCalculator");
        }
    }
    class AbstractEg
    {
        static void Main()
        {
            //  AICTE aobj = new AICTE();

            /*    MIT mobj = new MIT();
                mobj.TotalCollgeRegisterd();
                mobj.GradeCalculator();
                SRM sobj = new SRM();
                sobj.GradeCalculator();*/

            //Dynamic Polymorphism
            AICTE aobj;
            aobj = new MIT();
            aobj.GradeCalculator();//MIT
            aobj.TotalCollgeRegisterd(); 
            aobj = new SRM();
            aobj.GradeCalculator();//SRM
        }
    }
}
