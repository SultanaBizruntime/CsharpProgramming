using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Exception7
    {
        public static void Main()
        {
            Student2 std = null;

            try
            {
                try
                {
                    // following throws NullReferenceException
                    std.StudentName = "";
                }
                catch (InvalidOperationException innerEx)
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
    public class Student2
    {

        public string StudentName { get; set; }
    }
}
