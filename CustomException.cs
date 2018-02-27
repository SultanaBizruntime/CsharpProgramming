using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class CustomException
    {
        public static void Main()
        {
            throw new UserAlreadyLoggedInException("user is logged in");

        }
    }
    public class UserAlreadyLoggedInException : Exception
    {
        public UserAlreadyLoggedInException() : base()
        { }
        public UserAlreadyLoggedInException(string message) : base(message)
        { }

    }
   
}
