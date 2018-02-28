using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Singletonclass
    {
       // private static object syncRoot = new Object();
        private static Singletonclass instance = null;
        // private constructor
        private Singletonclass()
        {
        }
        /// <summary>
        /// Gets an instance with default parameters based upon the caller
        /// </summary>
        /// <returns></returns>

        public static Singletonclass GetInstance()
        {
            // make sure you return single instance
            if (instance == null)
            {
                lock (instance)
                {
                    if (instance == null)
                    {
                        instance = new Singletonclass();
                    }
                }
            }
            return instance;
        }
    }
}
