using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesEg
{
    class FilesandDirectives
    { 
        static void Main()
        {
            string root = @"D:\CGI";
            string subdir = @"D:\CGI\Files";
            //check directory is created if not create a directory
            if(!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }
            //check subdirectory is created if not create a subdirectory
            if (!Directory.Exists(subdir))
            {
                Directory.CreateDirectory(subdir);
                Console.WriteLine("SubDir created");
            }
            string filepath = @"D:\CGI\Files\HelloWorld.txt";
            Console.WriteLine("Enter the data to pass to file");
                string getdata = Console.ReadLine();
            //create a file and write the data inside the file
            File.WriteAllText(filepath, getdata);
            Console.WriteLine("File Created");

            FileInfo fileInfo = new FileInfo(filepath);
            Console.WriteLine("fileExists:{0}",fileInfo.Exists);
            Console.WriteLine("filename:{0}", fileInfo.Name);
            Console.WriteLine("lastwrite:{0}", fileInfo.LastWriteTime);

            foreach(string childDir in Directory.GetDirectories(root))
            {
                Console.WriteLine("Childdir:{0}",childDir);
            }
        }
    }
}
