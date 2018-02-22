using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    //Jagged Array
    class Array3
    {
        static void Main()
        {
            int[][] A = new int[3][];
            A[0] = new int[4] { 10, 20, 30,40 };
            A[1] = new int[2] { 10, 20 };
            A[2] = new int[3] { 10, 20, 30 };


            for (int r = 0; r < A.Length; r++)
            {
                for (int c = 0; c < A[r].Length; c++)
                {
                    Console.Write(A[r][c] + "  ");

                }
                Console.WriteLine();
            }
            Console.Read();
        }
        
    }
}
