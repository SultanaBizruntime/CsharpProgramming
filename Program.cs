using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        static void Main1()
        {
            Console.WriteLine("welcome to c#");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hi ");
            string UserName = Console.ReadLine();
           // Console.WriteLine("sulu" + UserName);
            Console.WriteLine("sulu {0}", UserName);


            // Main1();
            Console.ReadLine();
        }
    }
}
