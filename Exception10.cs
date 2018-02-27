using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Exception10
    {
        public static void Main()
        {
            StreamReader streamReader1 = null;


            try
            {
                streamReader1 = new StreamReader(@"D:\src1\file.txt");//DictoryNotFoundException
                StreamReader streamReader = new StreamReader(@"D:\file.txt");
                Console.WriteLine(streamReader.ReadToEnd());


            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("please check if the file {0} exists", ex.FileName);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(ex.StackTrace);

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(ex.StackTrace);

            }
            finally
            {
                if (streamReader1 != null)
                {
                    streamReader1.Close();
                    Console.WriteLine("from finally block");
                }
            }
            Console.Read();
            }
        }
    }

