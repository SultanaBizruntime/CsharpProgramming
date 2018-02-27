using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class Exception2
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter two numbers: ");

            try
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                int result = num1 / num2;

                Console.WriteLine("{0} / {1} = {2}", num1, num2, result);
            }
            catch (DivideByZeroException ex)
            {
                //LogError(ex);
                Console.Write("Cannot divide by zero. Please try again." + ex);
            }
            catch (InvalidOperationException ex)
            {
               // LogError(ex);
                Console.Write("Not a valid number. Please try again." +  ex);
            }
            catch (FormatException ex)
            {
                //LogError(ex);
                Console.Write("Not a valid number. Please try again." + ex);
            }

            Console.ReadKey();
        }


    }
}
