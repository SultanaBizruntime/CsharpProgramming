using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   public class Logg2
    {
        //Declare an instance for log4net
        private static readonly ILog Log =
              LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            Log.Info("Some text here");
            try
            {
                int i = 5;
                int j = 0;
                int res = i / j;
            }
            catch (Exception ex)
            {
                Log.Error(ex);
            }
        }

    }
}
