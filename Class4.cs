using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Class4
    {
        static void Main1()
        {
            string s1 = "\"sulu\"";
            string s2 = "\'syed\'";
            string s3 = @"suluu\\riz\\suhani";
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.Read();
        }

        static void Main()
        {
            int Number = 10;
            int Number1 = 20;

            //ternary operator
            bool IsNumber11 = Number1 == 20 ? true : false;

            //if -else
            bool IsNumber10;

            if (Number == 10)
            {
                IsNumber10 = true;
            }
            else
            {
                IsNumber10 = false;
            }

            Console.WriteLine("Number == 10 is {0}", IsNumber10);

            Console.WriteLine("Number1 == 20 is {0}", IsNumber11);
            Main1();
            Console.Read();

        }
    }
}
