using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//program that implements indexer on interface

namespace ConsoleApp2
{
    interface IPerl
    {
        int this[int number] { get; set; }
    }

    class Implementation : IPerl
    {
        int[] _data = { 0, 10, 20, 30 }; // Default values
        public int this[int number]
        {
            get
            {
                // Get accessor implementation.
                return this._data[number];
            }
            set
            {
                // Set accessor implementation.
                this._data[number] = value;
            }
        }
    }

    class Indexer3
    {
        static void Main()
        {
            // Create an object instance.
            // ... Use the indexer through the interface type.
            IPerl perl = new Implementation();
            Console.WriteLine(perl[0]);
            Console.WriteLine(perl[1]);
            Console.WriteLine(perl[2]);
            Console.WriteLine(perl[3]);
            // Use set accessor.
            perl[0] = -1;
            Console.WriteLine(perl[0]);
            Console.Read();
        }
    }
}
