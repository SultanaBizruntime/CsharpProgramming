using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class SwitchCase
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number");
            int UserNo = int.Parse(Console.ReadLine());

            switch (UserNo)
            {
                case 10:
                    Console.WriteLine("Your No is 10");
                    break;
                case 20:
                    Console.WriteLine("Your No is 20");
                    break;
                case 30:
                    Console.WriteLine("Your No is 30");
                    break;
                default:
                    Console.WriteLine("Your No is not 10,20,30");
                    break;

            }
            Console.Read();
        }
    }
}
