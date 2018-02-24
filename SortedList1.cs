using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class SortedList1
    {
        public static void Main()
        {
            SortedList<int, string> sortedList1 = new SortedList<int, string>();
            sortedList1.Add(3, "Three");
            sortedList1.Add(4, "Four");
            sortedList1.Add(1, "One");
            sortedList1.Add(5, "Five");
            sortedList1.Add(2, "Two");

            Console.WriteLine(sortedList1.Count);
            Console.WriteLine("..................");

            SortedList<string, int> sortedList2 = new SortedList<string, int>();
            sortedList2.Add("one", 1);
            sortedList2.Add("two", 2);
            sortedList2.Add("three", 3);
            sortedList2.Add("four", 4);
            // Compile time error: cannot convert from <null> to <int>
            // sortedList2.Add("Five", null);

            Console.WriteLine(sortedList2.Count);
            Console.WriteLine("..................");

            SortedList<double, int?> sortedList3 = new SortedList<double, int?>();
            sortedList3.Add(1.5, 100);
            sortedList3.Add(3.5, 200);
            sortedList3.Add(2.4, 300);
            sortedList3.Add(2.3, null);
            sortedList3.Add(1.1, null);

            Console.WriteLine(sortedList3.Count);
            Console.WriteLine("..................");


            SortedList<string, int> sortedList4 = new SortedList<string, int>();
            sortedList4.Add("one", 1);
            sortedList4.Add("two", 2);
            sortedList4.Add("three", 3);
            sortedList4.Add("four", 4);

            Console.WriteLine(sortedList4["one"]);
            Console.WriteLine(sortedList4["two"]);
            Console.WriteLine(sortedList4["three"]);

            //Following will throw runtime exception: KeyNotFoundException
            //Console.WriteLine(sortedList2["ten"]);
            Console.WriteLine("..................");

            SortedList<string, int> sortedList5 = new SortedList<string, int>();
            sortedList5.Add("one", 1);
            sortedList5.Add("two", 2);
            sortedList5.Add("three", 3);
            sortedList5.Add("four", 4);

            for (int i = 0; i < sortedList2.Count; i++)
            {
                Console.WriteLine("key: {0}, value: {1}", sortedList5.Keys[i], sortedList5.Values[i]);
            }
            Console.WriteLine("..................");

           // foreach statement to access generic SortedList:

            SortedList<string, int> sortedList6= new SortedList<string, int>();
            sortedList6.Add("one", 1);
            sortedList6.Add("two", 2);
            sortedList6.Add("three", 3);
            sortedList6.Add("four", 4);

            foreach (KeyValuePair<string, int> kvp in sortedList6)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);
            Console.WriteLine("..................");

           // TryGetValue

            SortedList<string, int> sortedList7 = new SortedList<string, int>();
            sortedList7.Add("one", 1);
            sortedList7.Add("two", 2);
            sortedList7.Add("three", 3);
            sortedList7.Add("four", 4);

            int val;

            if (sortedList7.TryGetValue("ten", out val))
                Console.WriteLine("value: {0}", val);
            else
                Console.WriteLine("Key is not valid.");

            if (sortedList7.TryGetValue("one", out val))
                Console.WriteLine("value: {0}", val);
            Console.WriteLine("..................");

            //Remove elements

            SortedList<string, int> sortedList8 = new SortedList<string, int>();
            sortedList8.Add("one", 1);
            sortedList8.Add("two", 2);
            sortedList8.Add("three", 3);
            sortedList8.Add("four", 4);

            sortedList8.Remove("one");//removes the element whose key is 'one'
            sortedList8.RemoveAt(0);//removes the element at zero index i.e first element: four

            foreach (KeyValuePair<string, int> kvp in sortedList8)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);
            Console.WriteLine("..................");


            // Contain()
            SortedList<string, int> sortedList9 = new SortedList<string, int>();
            sortedList9.Add("one", 1);
            sortedList9.Add("two", 2);
            sortedList9.Add("three", 3);
            sortedList9.Add("four", 4);
            sortedList9.Add("five", 5);


            sortedList9.ContainsKey("One"); // returns true
            sortedList9.ContainsKey("Ten"); // returns false
            Console.WriteLine(".............................");


            // Access SortedList< TKey, TValue > using LINQ method syntax

            SortedList <string, int> sortedList = new SortedList<string, int>();
            sortedList.Add("one", 1);
            sortedList.Add("two", 2);
            sortedList.Add("three", 3);
            sortedList.Add("four", 4);
            sortedList.Add("five", 5);

            var result = sortedList.Where(kvp => kvp.Key == "two").FirstOrDefault();

            Console.WriteLine("key: {0}, value: {1}", result.Key, result.Value);

            Console.WriteLine(".................");
            Console.Read();






            sortedList.ContainsValue(2); // returns true
            sortedList.ContainsValue(6); // returns false


        }


    }
}
