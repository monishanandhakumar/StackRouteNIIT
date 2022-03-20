using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjOOP
{
    class Student
    {
        //Data member
        int sid;
        string sname;

        //Overloading
        Student()
        {
            Console.WriteLine("Default Constructor");
        }
        Student(int id,string name)
        {
            sid = id;
            sname = name;

        }
        Student(int id)
        {

        }
        void Display()
        {
            Console.WriteLine("sid:{0} || sname:{1}",sid,sname);
        }
         static void Main()
        {
            Student s = new Student();
            Student s1 = new Student(1001,"Anand");
            //s1.sid = 1001;
            //s1.sname = "Anand";
            s1.Display();
            Student s2 = new Student(1002,"Tim");
           // s2.sid = 1002;
           // s2.sname = "Tim";
           
            s2.Display();
        }

    }
}
