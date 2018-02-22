using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Nullable
    {
        static void Main()
        {
            bool? AreYouMajor = null;
            if (AreYouMajor == true)
            {
                Console.WriteLine("user is major");
            }
            else if (AreYouMajor == false)
            {
                Console.WriteLine("user is not major");
            }
            else
            {
                Console.WriteLine(" User did not answer the question");
            }
        }
    }
}
