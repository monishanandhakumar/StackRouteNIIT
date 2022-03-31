using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesEg
{
    class StreamreadwriteEg
    {
        public static void Main()
        {
            string path = @"D:/Sample.txt";
            using(StreamReader sr=File.OpenText(path))
            {
                string s = "";
                while((s=sr.ReadLine())!=null)
                {
                    Console.WriteLine(s);
                }
                sr.Close();
            }

            using (StreamWriter sw = File.AppendText(path))
            {
                Console.WriteLine("Reading from file");
                sw.WriteLine("/n Demo");
                sw.Close();
                Console.WriteLine(File.ReadAllText(path));
            }

        }
    }
}
