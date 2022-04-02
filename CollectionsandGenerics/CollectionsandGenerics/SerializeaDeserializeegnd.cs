using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace CollectionsandGenerics
{
    [Serializable]
   public class Student
    {
        public int sid { get; set; }
        public string sname { get; set; }
        public int age { get; set; }
        
    }
    [Serializable]
   public class SerializeaDeserializeegnd
    {
        public void SerializeEg()
        {
            Student[] students = new Student[2];
            students[0] = new Student();
            students[0].sid = 1001;
            students[0].sname = "Hari";
            students[0].age = 21;
            students[1] = new Student();
            students[1].sid = 1002;
            students[1].sname = "Siva";
            students[1].age = 20;
            //Encryption and Decryption
            //IFormatter->Interface(Serialize and Deserialize),BinaryFormatter(class)->inheriting->IFormatter

            //Base->Derived
            IFormatter formatter = new BinaryFormatter();

            //Stream->abstract class,Filestream(class)-inheriting the stream class
            //Base->Derived
            Stream stream = new FileStream(@"D:\Studentinfo.txt", FileMode.Create, FileAccess.Write);

            //stream->ExampleNew.txt  obj->ID and Name
            formatter.Serialize(stream, students);
            stream.Close();
            Console.WriteLine("Data Serialized ");
            
        }
        
        public void Deseralize()
        {
            Student[] stu;
            //Base->Derived
            
            Stream stream = new FileStream(@"D:\Studentinfo.txt", FileMode.Open, FileAccess.Read);

            //Base->Derived
            IFormatter formatter = new BinaryFormatter();
            //Files-user-defined class
            //(Files)->typecasting the content into class object
            Student[] objnew = (Student[])formatter.Deserialize(stream);

            Console.WriteLine(objnew[0].sid);
            Console.WriteLine(objnew[0].sname);
            Console.WriteLine(objnew[0].age);


        }
        static void Main()
        {
            SerializeaDeserializeegnd obj = new SerializeaDeserializeegnd();
            obj.SerializeEg();
            obj.Deseralize();
        }
    }
}
