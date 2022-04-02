using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsandGenerics
{
    [TestFixture]
    class EmployeeTestCase
    {
        AccessLayer ac = new AccessLayer();
        [Test]
        public void CheckNull()
        {
            //   List<EmployeeDetails> emplist = ac.AllUser();
            var emplist = ac.AllUser();
            foreach(var item in emplist)
            {
                Assert.IsNotNull(item.eid);
                Assert.IsNotNull(item.ename);
                Assert.IsNotNull(item.salary);
            }

        }


    }
}
