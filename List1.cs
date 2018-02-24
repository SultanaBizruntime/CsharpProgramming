using ConsoleApp2;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class List1
    {
        Customer1 customer1 = new Customer1()
        {
            ID = 101,
            Name = "SULU",
            Salary = 5000


        };
        Customer1 customer2 = new Customer1()
        {
            ID = 102,
            Name = "SRIZ",
            Salary = 60000


        };
        Customer1 customer3 = new Customer1()
        {
            ID = 103,
            Name = "SSSS",
            Salary = 3500


        };

       

         


        



    }

    public class Customer1
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}

