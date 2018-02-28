using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    interface I3
    {
        void InterfaceMethod();
    }
    interface I4
    {
        void InterfaceMethod();
    }
    public class Interface3 : I3, I4
    {
        //Declare an instance for log4net
        private static readonly ILog Log =
              LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        void I3.InterfaceMethod()
        {
            Log.Info("I3 interface Method");

            
        }
        void I4.InterfaceMethod()
        {
            Log.Info("I3 interface Method");

            throw new NotImplementedException();
        }


        static void Main()
        {
            Interface3 i1 = new Interface3();

            //Explicitly implementing interface

            ((I3)i1).InterfaceMethod();
            ((I4)i1).InterfaceMethod();
        }
    }

}
