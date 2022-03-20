using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjOOP
{
    // //default access specifier for internal
    class Organization
    {
        //default access specifier for member and member function is private
        int orgid;
       internal string orgname;

     internal  void Displaydata()
        {
            orgid = 101;
            int a = 10; //private
            Console.WriteLine(orgid+" "+orgname);
        }
       // a=20; private
        //int Calculate()
        //{
        //   // return a * a; private
        //}

    }
    class AccessSpecifiersEg
    {
        static void Main()
        {
          /*  Organization obj = new Organization();
            //   obj.orgid = 10;
            obj.orgname = "CGI";
            obj.Displaydata();*/

        }
    }
}
