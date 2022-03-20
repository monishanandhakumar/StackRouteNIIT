using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingBasic2
{
    enum Subject
    {
        m1=100,m2=200
    }
   public struct Student
    {
        public int sid;
        public string name;
        public int m1;
        public int m2;

    }
    class StructEg1
    {
        public static int CalculateAvg(Student student)
        {
            // int sumofsubject = (int)Subject.m1 + (int)Subject.m2;
            int avg = (student.m1 + student.m2)/2;
            
            return avg;
        }

        public static StringBuilder GenerateScoreCard(Student student)
        {
            StringBuilder stu = new StringBuilder();
            stu.Append(student.sid);
            stu.Append(student.name);
            stu.Append(CalculateAvg(student));
            return stu;
        }

        public static void Getdata(Student[] students)
        {
            foreach(var s in students)
            {
                int sum = s.m1 + s.m2;
                Console.WriteLine(s.sid+" "+s.name+" "+sum);
            }

        }
        public static void Main()
        {
            Student s1 = new Student();
            s1.sid = 1001;
            s1.name = "Sri";
            s1.m1 = 90;
            s1.m2 = 78;
            Console.WriteLine(GenerateScoreCard(s1));

            Student[] s2= new Student[2];
            s2[0] = new Student() {sid=1002,name="gaya",m1=90,m2=89 };
            s2[1] = new Student() { sid = 1003, name = "Kalai", m1 = 98, m2 = 89 };

            Getdata(s2);
        }
    }
}
