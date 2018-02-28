using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    interface ICustomer
    {
        void print();
    }

    interface I2
    {
       void  I2Method();
    }
  //  static readonly ILog Log =
          //  LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    class Employee : ICustomer
    {
        private static readonly ILog Log =
          LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        public void print()
        {
            Log.Info("Interface Print Method");
        }


        public void I2Method()
        {
            Log.Info("From I2 interface");

        }
    }
    class Interface1
    {
        //Declare an instance for log4net
        private static readonly ILog Log =
              LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static void Main()
        {
            Employee e1 = new Employee();
            e1.print();
            e1.I2Method();
        }
    }
}
