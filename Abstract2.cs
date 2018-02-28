using log4net;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
   

    abstract class FourLeggedAnimal1
    {
        public abstract string Describe();
    }

    class Dog1 : FourLeggedAnimal1
    {

        public override string Describe()
        {
            return "I'm a dog!";
        }
    }

    class Cat1 : FourLeggedAnimal1
    {
        public override string Describe()
        {
            return "I'm a cat!";
        }
    }
    class Abstract2
    {
        //Declare an instance for log4net
        private static readonly ILog Log =
              LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            ArrayList animalList = new ArrayList();
            animalList.Add(new Dog1());
            animalList.Add(new Cat1());
            foreach (FourLeggedAnimal1 animal in animalList)
                Log.Info(animal.Describe());
            Log.Info("Done");
        }

    }

}
