using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class OptionalParam1
    {
        static void Main(string[] args)
        {
            AddNumber(10, 20);
        }
        public static void AddNumber(int firstName, int secondNumber, params object[] restOfTheNumber)
        {
            int result = firstName + secondNumber;

            foreach (int i in restOfTheNumber)
            {
                result += i;
            }
            Console.WriteLine("Total = " + result);

            Console.Read();
        }
    }
}
  