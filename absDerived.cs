using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    //Creating an Abstract Class
    abstract class absClass
    { 

        //Declare an instance for log4net
        private static readonly ILog Log =
              LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        //A Non abstract method
        public int AddTwoNumbers(int Num1, int Num2)
            {
                return Num1 + Num2;
            }

            //An abstract method, to be
            //overridden in derived class
            public abstract int MultiplyTwoNumbers(int Num1, int Num2);


        //NonAbstractMethod
        public void NonAbstractMethod()
            {
               Log.Info("NonAbstract Method");
            }

    }
    class absDerived : absClass
    {
        //Declare an instance for log4net
        private static readonly ILog Log =
              LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            //You can create an
            //instance of the derived class

            absDerived calculate = new absDerived();
            int added = calculate.AddTwoNumbers(10, 20);
            int multiplied = calculate.MultiplyTwoNumbers(10, 20);
            Log.InfoFormat("Added : {0},  Multiplied: ", added, multiplied);
            Log.Warn("This is a Warning message");
            Log.Debug("Did it again!");

        }

        //using override keyword,
        //implementing the abstract method
        //MultiplyTwoNumbers
        public override int MultiplyTwoNumbers(int Num1, int Num2)
        {
            return Num1 * Num2;
        }
    }
    
}
