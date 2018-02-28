using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    //Explicit and Default interface implementation
    interface I7
    {
        void InterfaceMethod();
    }
    interface I8
    {
        void InterfaceMethod();
    }

    class Interface5 : I7,I8
    {

        //Declare an instance for log4net
        private static readonly ILog Log =
              LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public void InterfaceMethod()
        {
            Log.Info("I3 interface Method");

        }
        void I8.InterfaceMethod()
        {
            Log.Info("I3 interface Method");

        }

        static void Main()
        {
            //Explicitly implementing interface

            Interface5 i1 = new Interface5();

           // I6 i2 = new Interface4();

            i1.InterfaceMethod();
            ((I8)i1).InterfaceMethod();




        }
    }
}
