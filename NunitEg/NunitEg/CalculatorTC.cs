using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitEg
{
    [TestFixture]
    class CalculatorTC
    {
        Calculator cobj = new Calculator();
        [Test]
        public void Addition()
        {
            Assert.AreEqual(10,cobj.Add(90, 10));
        }

        [Test]
        public void Subtraction()
        {
            Assert.AreEqual(70, cobj.Sub(80, 10));
        }

        [Test]
        public void SubtractionArgumentException()
        {
            Assert.Catch<ArgumentException>(() => cobj.Sub(2,3));
        }
    }
}
