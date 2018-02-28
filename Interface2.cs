using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    interface ICustomer1
    {
        void Print1();

    }
    interface ICustomer2 : ICustomer1
    {
        void Print2();
    }
    public class Employee1 : ICustomer2
    {
        //Declare an instance for log4net
        private static readonly ILog Log =
              LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public void Print2()
        {
            Log.Info("From print2()");
        }

        public void Print1()
        {
            Log.Info("From print1()");
        }
    }

    public class Interface2
    {
        static void Main()
        {
            Employee1 e1 = new Employee1();
            e1.Print1();
            e1.Print2();
            ICustomer1 cust = new Employee1();
            cust.Print1();



        }
    }
}
