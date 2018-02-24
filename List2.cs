using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class List2
    {
        static void Print(IList<string> list)
        {
            Console.WriteLine("Count: {0}", list.Count);
            foreach (string value in list)
            {
                Console.WriteLine(value);
            }
        }


        static bool isPositiveInt(int i)
        {
            return i > 0;
        }



        public static void Main()
        {
            List<int> intList = new List<int>();
            intList.Add(10);
            intList.Add(20);
            intList.Add(30);
            intList.Add(40);

            Console.Write(intList + "  ");
            Console.WriteLine(intList.Count);
            Console.WriteLine("..........................");


            List<string> strList = new List<string>();
            strList.Add("one");
            strList.Add("two");
            strList.Add("three");
            strList.Add("four");
            strList.Add("four");
            strList.Add(null);
            strList.Add(null);

            Console.Write(strList + "  ");
            Console.WriteLine(strList.Count);
            Console.WriteLine("..........................");


            List<Student> studentList = new List<Student>();
            studentList.Add(new Student());
            studentList.Add(new Student());
            studentList.Add(new Student());

            Console.Write(studentList + "  ");
            Console.WriteLine(studentList.Count);
            Console.WriteLine("..........................");

            //AddRange()
            IList<int> intList1 = new List<int>();
            intList1.Add(10);
            intList1.Add(20);
            intList1.Add(30);
            intList1.Add(40);

            List<int> intList2 = new List<int>();

            intList2.AddRange(intList1);
            Console.WriteLine("..........................");


            //Accessing list using foreach
            List<int> intList4 = new List<int>() { 10, 20, 30 };

            intList4.ForEach(el => Console.WriteLine(el));
            Console.WriteLine("..........................");
            
            //Accessing list using var
            IList<int> intList5 = new List<int>() { 10, 20, 30, 40 };

            foreach (var el in intList5)
                Console.WriteLine(el);
            Console.WriteLine("..........................");

            IList<int> intList6 = new List<int>() { 10, 20, 30, 40 };

            int elem = intList6[1]; // returns 20
            Console.WriteLine("..........................");


            IList<int> intList7  = new List<int>() { 10, 20, 30, 40 };

            Console.Write("Total elements: {0}", intList7.Count);
            Console.WriteLine("..........................");



           // Accessing List using for loop example:

            IList < int > intList8 = new List<int>() { 10, 20, 30, 40 };

            for (int i = 0; i < intList8.Count; i++)
                Console.WriteLine(intList8[i]);
            Console.WriteLine("..........................");

            // Access List using static method
            string[] strArray = new string[2];
            strArray[0] = "Hello";
            strArray[1] = "World";
            Print(strArray);

            List<string> strList1 = new List<string>();
            strList1.Add("Hello");
            strList1.Add("World");
            Print(strList1);

            Console.WriteLine("..........................");

            //Insert elements into List

            IList<int> intList9 = new List<int>() { 10, 20, 30, 40 };

            intList9.Insert(1, 11);// inserts 11 at 1st index: after 10.

            foreach (var el in intList9)
                Console.Write(el);
            Console.WriteLine("..........................");

            //Remove elements
            IList<int> intList10 = new List<int>() { 10, 20, 30, 40 };

            intList10.Remove(10); // removes the 10 from a list

            intList10.RemoveAt(2); //removes the 3rd element (index starts from 0)

            foreach (var el in intList10)
                Console.Write(el);
            Console.WriteLine("..........................");

            //TrueForAll()

            List<int> intList11 = new List<int>() { 10, 20, 30, 40 };

            bool res = intList11.TrueForAll(el => el % 2 == 0);// returns true
            Console.WriteLine("..........................");

            //Predictive TrueForAll()
            List<int> intList12 = new List<int>() { 10, 20, 30, 40 };

            bool res1 = intList12.TrueForAll(isPositiveInt);


            Console.Read();

        }
    }

    public class Student
    {

    }
}

