using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{
    class File1
    {
        static void Main()
        {
            WriteForFile();
            ReadForFile();
            //Opens DummyFile.txt and append Text. If file is not exists then create and open.
            File.AppendAllText("DummyFile.txt", "This is File testing");

            //Opens DummyFile.txt and write texts. If file is not exists then create and open.
            File.WriteAllText("DummyFile.txt", "This is dummy text");

            //Check whether file is exists or not at particular location
            bool isFileExists = File.Exists(" DummyFile.txt"); // returns false


            //Copy DummyFile.txt as new file DummyFileNew.txt
            File.Copy("DummyFile.txt", "NewDummyFile.txt");


            //Get when the file was accessed last time
            DateTime lastAccessTime = File.GetLastAccessTime("DummyFile.txt");

            //get when the file was written last time
            DateTime lastWriteTime = File.GetLastWriteTime("DummyFile.txt");

            // Move file to new location
            File.Move("DummyFile.txt", @"D:\DummyFile.txt");

            //Open file and returns FileStream for reading bytes from the file
            FileStream fs = File.Open(@"D:\DummyFile.txt", FileMode.OpenOrCreate);

            //Open file and return StreamReader for reading string from the file
            StreamReader sr = File.OpenText(@"D:\DummyFile.txt");

            //Delete file
            File.Delete(@"C:\DummyFile.txt");






            Console.Read();
        }

        public static void WriteForFile()
        {
            StreamWriter write = new    StreamWriter("test.txt");
            write.WriteLine("Hello World");
            write.Close();

        }

        public static void ReadForFile()
        {
            StreamReader reader = new StreamReader("test.txt");
            Console.WriteLine(reader.ReadToEnd());
            reader.Close();
        }

    }
}
