using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{


    abstract class FourLeggedAnimal
    {
        /*FourLeggedAnimal someAnimal = new FourLeggedAnimal();
         *we cannot create the object of abstract class.
         * You will get this fine compiler error: 
         * */

        public virtual string Describe()
        {
            return "Not much is known about this four legged animal!";
        }
    }

    class Dog : FourLeggedAnimal
    {
        //override the Describe() 
        public override string Describe()
        {
            //return "This four legged animal is a Dog!";

            string result = base.Describe();
            result += " In fact, it's a dog!";
            return result;

        }

    }

    class Abstract1
    {
         static string result = null;
        //Declare an instance for log4net
        private static readonly ILog Log =
              LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Log.Info(dog.Describe());
            Log.Info( result);
           // Log.Info(FourLeggedAnimal.Describe());
            Console.WriteLine("abstraction");
        }

    }
}
