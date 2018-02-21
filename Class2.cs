using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Class2
    {
        static void Main()
        {
            Console.WriteLine("please enter your frst name");
            string FirstName = Console.ReadLine();

            Console.WriteLine("please enter your Last name");
            string LastName = Console.ReadLine();

            Console.WriteLine("Hello {0}, {1}", FirstName, LastName);
            Console.Read();


        }
    }
}
