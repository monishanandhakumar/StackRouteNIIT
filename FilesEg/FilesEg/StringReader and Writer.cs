using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesEg
{
    class StringReader_and_Writer
    {
        static void Main()
        {
            //Writing the value in stringwriter
            StringWriter stringWriter = new StringWriter();
            stringWriter.WriteLine("Welcome to stringReader class");
            stringWriter.Close();
            //Reading 
            StringReader read = new StringReader(stringWriter.ToString());
            while(read.Peek()>-1)
            {
                Console.WriteLine(read.ReadLine());
            }


        }
    }
}
