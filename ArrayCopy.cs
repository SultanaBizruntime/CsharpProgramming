using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ArrayCopy
    {
        static void Main()
        {

            int[] A = new int[5] { 1, 2, 3, 4, 5 };
            int[] B = new int[8] { 50, 10, 60, 20, 7, 30, 80, 40 };

            Console.WriteLine("Elements of Array A are:");
            foreach (int i in A)
            {
                Console.Write(i + " ");

            }
            Console.WriteLine();
            A.CopyTo(B, 2);
            Console.WriteLine("Elements of Array B after copying are:");

            foreach (int i in B)
            {
                Console.Write(i + " ");
            }
            Console.Read();

        }
    }
}
