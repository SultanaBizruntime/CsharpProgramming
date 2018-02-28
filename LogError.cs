using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class LogError
    {
        internal static void Testing()
        {
            log4net.Config.BasicConfigurator.Configure();
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(LogError));
            try
            {
                string str = String.Empty;
                string subStr = str.Substring(0, 4); //this line will create error as the string "str" is empty.  
            }
            catch (Exception ex)
            {
                log.Error("Error Message: " + ex.Message.ToString(), ex);
                log.Debug("Debbuging");
                log.Warn("warning occur");
                log.Fatal("failed System");
            }
        }

        static void Main(string[] args)
        {
            Testing();
           // Console.ReadLine();
        }

    }
}
