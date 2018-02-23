using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Hashtable1
    {
        static void Main(string[] args)
        {
            Hashtable ht1 = new Hashtable();
            ht1.Add("ename", "sulu");
            ht1.Add("eid", 456);
            ht1.Add("ecity", "bnglr");
            ht1.Add("esal", 854122666);
            Console.WriteLine();
            
            foreach (Object key in ht1.Keys)
            {
                Console.WriteLine( ht1[key]);
            }
            Console.ReadKey();
        }
    }
}
