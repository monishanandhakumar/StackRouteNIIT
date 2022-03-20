using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingBasic2
{
    enum feedback
    {
        //data members
       poor=1,fair,good,excellent
    }
    class Enumeg
    {
        public static void Main()
        {
            Console.WriteLine("The value for Poor:{0}",(int)feedback.poor);
            Console.WriteLine("The value for Fair:{0}", (int)feedback.fair);
            Console.WriteLine("The value for Good:{0}", (int)feedback.good);
            Console.WriteLine("The value for Excellent:{0}", (int)feedback.excellent);
        }
    }
}
