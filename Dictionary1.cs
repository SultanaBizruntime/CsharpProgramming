using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Dictionary1
    {
        Customer cust;
        public static void Main()
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "SULU",
                Salary = 5000


            };
            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "SRIZ",
                Salary = 60000


            };
            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "SSSS",
                Salary = 3500


            };

            Dictionary<int, Customer> dictionaryCustomers = new Dictionary<int, Customer>();
            dictionaryCustomers.Add(customer1.ID, customer1);
            dictionaryCustomers.Add(customer2.ID, customer2);
            dictionaryCustomers.Add(customer3.ID, customer3);

            //for a particular key

            Customer customer103 = dictionaryCustomers[103];
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer103.ID,
                customer103.Name, customer103.Salary);
            Console.WriteLine("....................................");
            //FOR multiple key value data

            foreach (KeyValuePair<int, Customer> customerKeyValuePair in dictionaryCustomers)
            {
                Console.WriteLine("key = {0}", customerKeyValuePair.Key);
                Customer cust = customerKeyValuePair.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
                Console.WriteLine("----------------------------------");

            }
            Console.WriteLine("....................................");

            //if we want to get just keys.
            foreach (int key in dictionaryCustomers.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("....................................");

            //if we want to get just Value
            foreach (Customer cust in dictionaryCustomers.Values)
            {
                Console.WriteLine("ID ={0}, Name ={1}, Salary = {2}", cust.ID, cust.Name, cust.Name);
                Console.WriteLine("---------------------------------");
            }
            Console.WriteLine("....................................");

            ////using TryGetValue()
           
            //if (dictionaryCustomers.TryGetValue(101, out cust))
            //{
            //    Console.WriteLine("ID= {0}, Name = {1} , Salary = {2}", cust.ID, cust.Name, cust.Salary);
            //}
            //else
            //{
            //    Console.WriteLine("The key is not found");
            //}
            Console.WriteLine("....................................");
            //using Count() of overloaded function

            Console.WriteLine("Total Items = {0}", dictionaryCustomers.Count(kvp => kvp.Value.Salary > 4000));

            Console.WriteLine("....................................");

            //using remove()
            dictionaryCustomers.Remove(102);

            Console.WriteLine("....................................");

            // converting arrays into Dictionary.

            Customer[] customers = new Customer[3];
            customers[0] = customer1;
            customers[1] = customer2;
            customers[2] = customer3;

            
            Dictionary<int, Customer> dict = customers.ToDictionary(cust=> cust.ID, cust => cust);
            foreach (KeyValuePair<int, Customer> kvp in dict)
            {
                Console.WriteLine("key = {0}", kvp.Key);
                Customer cust = kvp.Value;
                Console.WriteLine("ID = {0} , Name = {1} , Salary = {2}", cust.ID, cust.Name, cust.Salary);
            }



            Console.Read();
        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
