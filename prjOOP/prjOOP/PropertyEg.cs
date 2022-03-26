using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjOOP
{
    class Mobile
    {
       public string IMEI { get; private set; }
       public string Mobilename { get; set; }
     internal  Mobile()
        {
            IMEI = "kdh89";
        }
    }
    class PropertyEg
    {
        static void Main()
        {
            Mobile mobile = new Mobile();
            Console.WriteLine("IMEI:{0}",mobile.IMEI);
            mobile.Mobilename = "Pixel4a";
            Console.WriteLine("MobileName:{0}",mobile.Mobilename);
       

        }
    }
}
