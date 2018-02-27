using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Exception4
    {
        static void Main()
        {
              //Example: Invalid catch block
            try
            {
                string s = "";
                Console.WriteLine(s.Length);
            }
            catch
            {
                // this catch block must be last block
            }
            catch (NullReferenceException nullEx)
            {
                Console.WriteLine(nullEx.Message);
            }
            catch (InvalidCastException inEx)
            {
                Console.WriteLine(inEx.Message);
            }
        }
    }
}
