using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class InnerException
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter first Number");
                int FN = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter second Number");
                int SN = Convert.ToInt32(Console.ReadLine());
                int Result = FN / SN;
                Console.WriteLine("Result = {0}", Result);
            }
            catch (Exception ex)
            {
                string filePath = @"D:\file1.txt";
                if (File.Exists(filePath))
                {
                    StreamWriter sw = new StreamWriter(filePath);
                    sw.Write(ex.GetType().Name);
                    sw.WriteLine();
                    sw.Write(ex.Message);
                    sw.Close();
                    Console.WriteLine("there is a problem, please try later");

                    Console.WriteLine();
                }
                else
                {
                    throw new FileNotFoundException(filePath + "is not present", ex);
                }
            }
           

            Console.Read();
        }
       
    }
}
