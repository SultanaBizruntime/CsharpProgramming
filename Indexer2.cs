using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    //program that uses indexer initializer
    class Indexer2
    {

        static void Main()
        {
            // ... Use an index initializer.
            Farm f = new Farm() { [1] = "cat", [3] = "bird", [5] = "dog" };
            // Get values from farm by index.
            WriteLine(f[1]);
            WriteLine(f[3]);
            WriteLine(f[5]);
            Console.Read();
        }
    }

    class Farm
    {
        string[] _animals = new string[10];

        public string this[int number]
        {
            get
            {
                return _animals[number];
            }
            set
            {
                _animals[number] = value;
            }
        }
    }
}
