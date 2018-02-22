using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class DynamicArray
    {
        static void Main()
        {
            int[] A = new int[6] { 10, 20, 30, 40, 50, 60 };
            Console.WriteLine("Elements of Arrays are:");
            foreach (int i in A)
            {
                Console.Write(i + "  ");
            }

            Console.WriteLine("\n Enter new size of array:");
            int N = Convert.ToInt32(Console.ReadLine());

            Array.Resize(ref A, N);
            Console.WriteLine("\n elements of array after resize are :");

            foreach(int i in A)
           {
                Console.Write(i + "  ");

           }
            Console.Read();
        }
    }
}
