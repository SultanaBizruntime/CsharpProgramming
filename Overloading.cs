using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{

    public class cls

    {

        public void display()

        {
            Console.WriteLine("HELLO");

        }

        public void display(string sname)

        {

            Console.WriteLine("HELLO" + sname);
         }

    }

    class Overloading
    {

        static void Main(string[] args)

        {

            cls obj = new cls();

            obj.display();          //call first display method which takes no
            obj.display("neha");  //call second display method which takes one
             Console.ReadLine();

        }

    }
}

