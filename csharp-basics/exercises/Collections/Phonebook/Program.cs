using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneBook;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
           var name = Console.ReadLine();
           var number = Console.ReadLine();
           
           var phoneDirectory = new PhoneDirectory(name, number);

           foreach (var s in phoneDirectory._data)
           {
               Console.WriteLine(s.Key);
               Console.WriteLine(s.Value);
           }

           Console.ReadKey();
        }
    }
}
