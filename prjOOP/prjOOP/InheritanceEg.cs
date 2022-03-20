using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjOOP
{
    class University   //grandParent 
    {
       internal string id;
        protected string uname ;
        protected string city="Mumbai";

        internal University(string id)
        {
            Console.WriteLine("UniversityConstructor");
            //This key word refers to current class instance variable
            this.id = id;
        }
      protected  string DisplayUniversity()
        {
            return uname;
        }

       internal void DisplayUID ()
        {
            Console.WriteLine("UniversityClass");
            Console.WriteLine(id);
        }
    }

    class Cadet:University //Parent
    {
        internal int rollno;
        internal string sname;
        string city = "Pune";

        internal Cadet(string id ,int rollno, string sname):base(id)
        {
            Console.WriteLine("CadetConstructor");
            this.rollno =rollno ;
            this.sname = sname;
        }
      internal  void DisplayStudata()
        {
            Console.WriteLine("CadetClass");
            uname = "MIT";
            Console.WriteLine(DisplayUniversity()); 
            Console.WriteLine("uname:{0}||rollno:{1}||sname:{2}",uname,rollno,sname);
            Console.WriteLine("University_City:{0} || StudentCity:{1}",base.city,city);
        }

    }
    class Activities:Cadet //Child
    {
        string extraactivity;

        Activities(string id, int rollno, string sname, string extraactivity) : base(id,rollno,sname)
        {
            Console.WriteLine("ActivitesConstructor");
            this.extraactivity = extraactivity;
        }
        internal void DisplayActivity()
        {
            Console.WriteLine("ActivityClass");
            Console.WriteLine(DisplayUniversity());
            Console.WriteLine("Name:{0}||University:{1}||Activity:{2}",sname,uname, extraactivity);
        }


    }
    class InheritanceEg
    {
        static void Main()
        {

            /*   Cadet student = new Cadet();
                student.rollno = 101;
                student.sname = "Sri";
                student.DisplayUID();
                student.DisplayStudata();*/
            Activities activities = new Activities("u001",101,"Sri","playing");
           // activities.rollno = 101;
           // activities.sname = "SRI";
            activities.DisplayUID();
            activities.DisplayStudata();
            activities.DisplayActivity();


        }
    }
}
