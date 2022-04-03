using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsandGenerics
{
    class Engine
    {
        internal string Enginetype()
        {
            return "Engine";
        }

    }
    class Car
    {
        public int noofwheels { get; set; }

        public string color { get; set; }
    }

    class Honda:Car //IS-A
    {
        public string Modelno { get; set; }

        internal void GETCardetails()
        {
            noofwheels = 4;
            color ="SilverGray";
            Modelno = "ZI890";
        }

        internal void DisplayCardetails()
        {
            Engine engine = new Engine();//Has- a
           
            Console.WriteLine(noofwheels+" "+color+" "+Modelno);
            Console.WriteLine("EngineType:{0}", engine.Enginetype());
        }


    }
    class RelationshipEg
    {
    }
}
