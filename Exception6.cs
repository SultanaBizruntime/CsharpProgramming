using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Exception6
    {
        static void Main(string[] args)
        {
            Student1 std = null;

            try
            {
                try
                {
                    std.StudentName = "";
                }
                catch
                {
                    Console.WriteLine("Inner catch");
                }
            }
            catch
            {
                Console.WriteLine("Outer catch");
            }
        }
    }


    public class Student1
    {

        public string StudentName { get; set; }
    }
}
/*
 * Nested try-catch:
 * --------------------
 * 
    C# allows nested try catch blocks. In the nested try catch block,
        an exception will be caught in the catch block that follows the try block where an exception occurred.
 * 
 */
