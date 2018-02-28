using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    //Abstract Class with abstract properties
    abstract class absClass
    {
        protected int myNumber;
        public abstract int numbers
        {
            get;
            set;
        }

        //Incorrect
        /* abstract sealed class absClass
         {
         } */


        /* An abstract method cannot be private

        //Incorrect
         private abstract int MultiplyTwoNumbers();*/


        /*An abstract method cannot have the modifier virtual.
        Because an abstract method is implicitly virtual.

        //Incorrect
        public abstract virtual int MultiplyTwoNumbers();*/


        /*
         * An abstract member cannot be static.
         * 
         * //Incorrect
           public abstract static int MultiplyTwoNumbers();
         * 
         */


    }

    class absDerived2 : absClass
    {
        //Declare an instance for log4net
        private static readonly ILog Log =
              LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

      
                    //Implementing abstract properties
                public override int numbers
                {
                    get
                    {
                        return myNumber;
                    }
                    set
                    {
                        myNumber = 54;
                    }
                }

        static void Main()
        {
            absDerived2 absDerived2 = new absDerived2();
            Log.Info(absDerived2.myNumber);
        }
    }

}

    

