using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsandGenerics
{
    public class EmployeeDetails
    {
        public int eid { get; set; }
        public string ename { get; set; }
        public double salary { get; set; }
    }

    public class AccessLayer
    {
        public List<EmployeeDetails> AllUser()
          
        {
            
            List<EmployeeDetails> li = new List<EmployeeDetails>();
            li.Add(new EmployeeDetails { eid = 101, ename = "Charan", salary = 78900 });
            li.Add(new EmployeeDetails { eid = 102, ename = "Gaya", salary = 88900 });
            li.Add(new EmployeeDetails { eid = 103, ename = "Divya", salary = 58900 });
            return li;
        }
    }
    class Employee
    {
        static void Main()
        {
            AccessLayer accessLayer = new AccessLayer();

            List<EmployeeDetails> emp = new List<EmployeeDetails>();
           emp= accessLayer.AllUser();
            foreach(var item in emp)
            {
                Console.WriteLine(item.eid+" "+item.ename+" "+item.salary);
            }
        }
    }
}
