using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class WithoutNullCoaleascing
    {
        static void Main()
        {
            int? TicketsOnSale = 100;
            int AvailableTickets;
            if (TicketsOnSale == null)
            {
                AvailableTickets = 0;
            }
            else
            {
                AvailableTickets = (int)TicketsOnSale;
            }

            Console.Write("AvailableTickets = {0}", AvailableTickets);
            Console.Read();

        }
    }
}
