using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Generics1
    {

        static void display<G>(G s)
        {
            Console.WriteLine("the value s is:-> " + s);
        }
        static void Main(string[] args)
        {
            display<int>(10);
            display<String>("Hello");
            display<double>(20.45);
            Console.Read();
        }
    }
}
