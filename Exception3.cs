using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Exception3
    {
        static void Main()
        {
            Console.Write("Please enter two numbers: ");

            try
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                int result = num1 / num2;

                Console.WriteLine("{0} / {1} = {2}", num1, num2, result);
            }

            catch //cannot have both catch and catch(Exception ex)
            {
                Console.WriteLine("Exception occurred");
            }
            catch (Exception ex) //cannot have both catch and catch(Exception ex)
            {
                Console.WriteLine("Exception occurred");
            }

        }
    }
}
/*
 * Invalid catch blocks:
 * ------------------------
    Parameterless catch block and a catch block with an Exception parameter are not allowed in the same try-catch statements,
    because they both do the same thing.
 */
