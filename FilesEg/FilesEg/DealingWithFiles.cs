using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesEg
{
    class DealingWithFiles
    {
     static void CreateFile()
        {
            try
            {
                string path = @"D:\FirstFile2.txt";
                FileStream fs = File.Create(path);
               Byte[] by = new UTF8Encoding(true).GetBytes("Good Morning!!!");
                fs.Write(by, 0, by.Length);
                Console.WriteLine("File Created");
            }
            catch(IOException e)
            {
                Console.WriteLine(e);
            }
           
        }

        static void DeleteFile()
        {
            try
            {
                string path = @"D:\FirstFile2.txt";
                File.Delete(path);
                Console.WriteLine("File Deleted");
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
            }

        }

        static void FileExist()
        {
            try
            {
                string path = @"D:\FirstFile4.txt";
                Console.WriteLine(File.Exists(path)?"File Exists":"Files not Exists");
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
            }

        }

        static void FileCopy()
        {
            try
            {
                string path = @"D:\Sample.txt";
                string path1 = @"D:\FirstFile.txt";
                File.Copy(path,path1,true);
                Console.WriteLine("File Copied");
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
            }

        }

        static void Main()
        {
            //DealingWithFiles.CreateFile();
            // DeleteFile();
            // FileExist();
            FileCopy();
        }


    }
}
