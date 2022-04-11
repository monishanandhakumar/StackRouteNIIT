using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsandGenerics
{
    class PhoneBook_Dic
    {
        static void Main()
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            phonebook.Add("Daya", "9012345678");
            phonebook.Add("Ravi", "7890567890");
            phonebook.Add("Lalitha", "9000345678");
            phonebook.Add("Kumar", "8012345678");
            phonebook.Add("Sri", "9016745678");

            Console.WriteLine("Enter the name");
            string name = Console.ReadLine();
            if(name !=null &&name.Length>0)
            {
                if(phonebook.ContainsKey(name))
                {
                    Console.WriteLine(name+"="+phonebook[name]);
                }
            }
            else
            {
                Console.WriteLine("No name found!!!");
            }

        }
    }
}
