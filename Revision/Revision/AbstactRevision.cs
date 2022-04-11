using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
   abstract class AICTE
    {
        public string Regno { get; set; }
      public abstract void CourseOffered();
        internal string Policies()

        {
            return "Policies";
        }
       
    }

    class KLU:AICTE
    {
        public override void CourseOffered()
        {
            Regno = "KLU9809";
            Console.WriteLine("BE-CSE,EEE,Mech,IT");
            Console.WriteLine("MBA-Finance,HumanResource");
        }
    }
    class MIT:AICTE
    {
        public override void CourseOffered()
        {
            Regno = "MIT9809";
            Console.WriteLine("UG:BE-CSE,EEE,Mech,IT");
            Console.WriteLine("PG:MBA-Finance,HumanResource");
            Console.WriteLine("PG:MTech,M.E");
        }
    }
    class AbstactRevision
    {
        static void Main()
        {
            string time = DateTime.Now.ToString("h:mm:ss tt");
            Console.WriteLine(time);
            AICTE aICTE;
           aICTE = new MIT();
           aICTE.CourseOffered();//MIT
            aICTE = new KLU();
           aICTE.CourseOffered();//KLU
        }
    }
}
