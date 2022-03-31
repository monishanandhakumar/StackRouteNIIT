using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesEg
{
    class FileStreamEg
    {
        public static void Main()
        {
            FileStream f=null;
            try
            {
                //File stream is created
              f  = new FileStream(@"D:/Trees.txt", FileMode.OpenOrCreate);
                for(int i=65;i<=90;i++)
                {
                    f.WriteByte((byte)i);
                }
                
            }
           catch(Exception e)
            {
                Console.WriteLine(e);
            }

            finally
            {
                f.Close();
            }
            
            
        }
    }
}
