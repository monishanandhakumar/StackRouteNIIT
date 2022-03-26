using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjOOP
{
    //Application Exception -User defined or custom exception
  public  class AgeNotvalid:ApplicationException
    {
        public AgeNotvalid(string msg):base(msg)
        {

        }
    }

    public class StateCheck:ApplicationException
    {
        public StateCheck(string m):base(m)
        {

        }
    }
    class CourseRegister
    {
        public void CheckEligibility(int age)
        {
            if(age<18)
            {
                throw new AgeNotvalid("Age should be greater than 18");
            }
            else
            {
                Console.WriteLine("your are eligible to register for the course");
            }
        }
    }
    class ExceptionHandling
    {
        public static void Main()
        {
            try
            {
                /*  int b=0;
                  int a = 10 / b;
                  Console.WriteLine("Hi All!!");
                  int[] marks = { 20, 30, 40, 50 };
                  Console.WriteLine(marks[5]);*/
                CourseRegister courseRegister = new CourseRegister();
                courseRegister.CheckEligibility(17);

            }
           catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
               // Console.WriteLine("Something Went Wrong!!!");
            }

            finally
            {
                Console.WriteLine("I am finally block");
                int area = 45 * 45;
                Console.WriteLine(area);
                
            }
            
          
        }
    }
}
