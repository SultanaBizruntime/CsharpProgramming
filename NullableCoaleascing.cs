using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class NullableCoaleascing
    {
        static void Main()
        {
            int? TicketsOnSale = 100;
            int AvailableTickets = TicketsOnSale ?? 0;
            Console.WriteLine("AvailableTickets = {0}", AvailableTickets);
            Console.Read();
        }
        
    }
}
// ?? is the null Coalescing operator.