using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Array1
    {
        static void Main(string[] args)
        {
            int[] A = new int[4] { 10, 20, 30, 40 };

            foreach (int i in A)
            {
                Console.Write(i + " ");
                Console.Read();
            }
        }
    }
}
