using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class G3<G1, G2>
    {
        public void display(G1 s1, G2 s2)
        {
            Console.WriteLine("the value s is:-> " + s1 + "," + s2);
        }
    }
    class Generics2
    {

        static void Main(string[] args)
        {
            G3<int, int> g1 = new G3<int, int>();
            G3<string, string> g2 = new G3<string, string>();
            G3<double, double> g3 = new G3<double, double>();

            g1.display(20, 10);
            g2.display("Hello", "how are you");
            g3.display(20.45, 125.12);
            Console.Read();
        }
    }
}
