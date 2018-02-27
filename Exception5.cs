using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Exception5
    {
        static void Main(string[] args)
        {
            int zero = 0;

            try
            {
                int result = 5 / zero;  // this will throw an exception       

            }
            catch (Exception ex)
            {
                Console.WriteLine("Inside catch block. Exception: {0}", ex.Message);
            }
            finally
            {
                Console.WriteLine("Inside finally block.");

            }
        }

    }
}
/*
 * Note :
 * ---------
 *  Multiple finally blocks are not allowed. Also, the finally block cannot have the return, continue,
 *  or break keywords. It doesn't allow control to leave the finally block.
 *  
 */
