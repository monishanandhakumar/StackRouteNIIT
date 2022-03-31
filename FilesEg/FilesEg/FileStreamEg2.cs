using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesEg
{
    class FileStreamEg2
    {
       void Writerfun()
        {
            //Open a new file using filestream class
            FileStream fout1 = new FileStream(@"D:/Trees.txt",FileMode.OpenOrCreate,FileAccess.Write,FileShare.ReadWrite);
            BinaryWriter bw1 = new BinaryWriter(fout1);
            //Variable 
            string SName = "Jancy";
            int age = 23;
            char gender = 'F';
            double Grade = 8.5;
            //values are written to the file
            bw1.Write(SName);
            bw1.Write(age);
            bw1.Write(gender);
            bw1.Write(Grade);
            bw1.Close();
            Console.WriteLine("Data updated !!!");
        }

        static void Main()
        {

        }
    }
}
