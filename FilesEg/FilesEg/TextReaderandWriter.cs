using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesEg
{
    class TextReaderandWriter
    {
        static void Main()
        {
            using (TextWriter writer = File.CreateText(@"D:/Subjects.txt"))
            {
                writer.WriteLine("1.OOPS 2.C# 3.Java");
                Console.WriteLine("Data inserted");
            }

            using (TextReader tr=File.OpenText(@"D:/Subjects.txt"))
            {
                string data = tr.ReadToEnd();
                Console.WriteLine(data);
            }
        }
    }
}
