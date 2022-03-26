using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjOOP
{
    class Studentinfo
    {
        public static string Dept;
        public int id { get; set; }
        public string stuname { get; set; }

        
        internal Studentinfo(int id,string stuname)
        {
            Console.WriteLine("Non static constructor");
            this.id = id;
            this.stuname = stuname;
        }
        static Studentinfo()
        {
            Console.WriteLine(" static constructor");
            Dept = "CSE";
        }
        internal static void DisplayDept()
        {
            int noofdepts = 10;
            Console.WriteLine("no of dept:{0}", noofdepts);

        }
        internal void DisplayData()
        {
            Console.WriteLine("sid:{0}||stuname:{1}||deptname:{2}",id,stuname,Dept);
        }
    }
    class StaticEg
    {
        static void Main()
        {
            Studentinfo[] studentinfos = new Studentinfo[2];
            for(int i=0;i<2;i++)
            {
                Console.WriteLine("Enter stuid,sname");
              //  string d = Console.ReadLine();
                int id = Convert.ToInt32(Console.ReadLine());
                string n= Console.ReadLine();
                studentinfos[i] = new Studentinfo( id, n);
                
            }

            for (int i = 0; i < 2; i++)
            {

                studentinfos[i].DisplayData();

            }
            Studentinfo.DisplayDept();
          

           

        }
    }
}
