using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class SwitchCase1
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number");
            int UserNo = int.Parse(Console.ReadLine());

            switch (UserNo)
            {
                //Joint switch cases
                case 10:
                case 20:
                case 30:
                    Console.WriteLine("Your No is : {0}", UserNo);
                    break;
                default:
                    Console.WriteLine("Your No is not 10,20,30");
                    break;

            }
            Console.Read();
        }

    }
}
