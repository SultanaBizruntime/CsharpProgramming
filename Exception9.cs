using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Exception9
    {
        public static void Main()
        {
            Student3 std = null;

            try
            {
                PrintStudentName(std);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

        public static void PrintStudentName(Student3 std)
        {
            if (std == null)
                throw new NullReferenceException("Student object is null. ");

            Console.WriteLine(std.StudentName);
        }

    }
    public class Student3
    {

        public string StudentName { get; set; }


    }
 }