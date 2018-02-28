using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    interface I5
    {
        void InterfaceMethod();
    }
    interface I6
    {
        void InterfaceMethod();
    }
    public class Interface4 : I5, I6
    {
        //Declare an instance for log4net
        private static readonly ILog Log =
              LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        void I5.InterfaceMethod()
        {
            Log.Info("I3 interface Method");

        }
        void I6.InterfaceMethod()
        {
            Log.Info("I3 interface Method");

        }

        static void Main()
        {
            //Explicitly implementing interface

            I5 i1 = new Interface4();

            I6 i2 = new Interface4();
            i1.InterfaceMethod();
            i2.InterfaceMethod();

            


        }
    }
}

