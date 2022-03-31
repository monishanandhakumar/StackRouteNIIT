using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitEg
{
    class Calculator
    {
        public int Add(int x,int y)
        {
            return x + y;
        }

        public int Sub(int x, int y)
        {
            if(x<y)
            {
                //throw new ArgumentException($"first number{x} is lesser than second number{y}");
                throw new ArgumentException("first number" + x + "is lesser than second number" +y);
            }
            return x - y;
        }
    }
}
