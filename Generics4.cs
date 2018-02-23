using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class GenericCustomer
    {
        public int id { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public double balance { get; set; }
    }
    class Generics4
    {
        static void Main(string[] args)
        {
            List<GenericCustomer> lgs = new List<GenericCustomer>();
            GenericCustomer c1 = new GenericCustomer { id = 101, name = "sulu", city = "BLR", balance = 1020.00 };
            GenericCustomer c2 = new GenericCustomer { id = 102, name = "riz", city = "BLRad", balance = 102500.00 };
            GenericCustomer c3 = new GenericCustomer { id = 101, name = "zarun", city = "BLRa", balance = 100540.00 };
            lgs.Add(c1);
            lgs.Add(c2);
            lgs.Add(c3);

            foreach (GenericCustomer gcobj in lgs)
                Console.WriteLine(gcobj.id + "  " + gcobj.name + "  " + gcobj.balance + "  " + gcobj.city);
            Console.ReadKey();
        }
    }
}
