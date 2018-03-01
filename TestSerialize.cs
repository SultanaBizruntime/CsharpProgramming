using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    /// <summary>
    /// TestSerialize is a class
    /// /// </summary>
    public class TestSerialize
    {
        //Declare an instance for log4net
        private static readonly ILog Log =
              LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        /// <summary>
        /// XMLSerializer is an object
        /// </summary>
        public static object XMLSerializer { get; private set; }

        static void Main()
        {
            Animal a1 = new Animal("sulu", 25, 20);
            Stream stream = File.Open("AnimalData.txt", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream,a1);

            stream.Close();
            a1 = null;
            stream = File.Open("AnimalData.txt", FileMode.Open);
             bf =  new BinaryFormatter();

            a1 = (Animal)bf.Deserialize(stream);
            stream.Close();

            Log.Info(a1.ToString());

            XMLSerializer serializer = new XMLSerializer(typeof(Animal));

            using (TextWriter tw = new StreamWriter(@"D:\Bizruntime\Xml_Documentation\Xml_Serialize.txt"))
            {
                serializer.Serialize(tw,a1);
            }
            a1 = null;
            XMLSerializer deserializer = new XMLSerializer(typeof(Animal));

            TextReader reader = new StreamReader(@"D:\Bizruntime\Xml_Documentation\Xml_Serialize.txt");
            Object obj = deserializer.Deserializer(reader);
            a1 = (Animal)obj;
            reader.Close();

            Log.Info(a1.ToString());

            List<Animal> theAnimals = new List<Animal>
            {

                new Animal("Mario", 30, 40),
                new Animal("liu", 25, 80),
                new Animal("peach", 10, 60)

            };

            using (Stream fs = new FileStream(@"D:\Bizruntime\Xml_Documentation\Xml_Serialize.xml", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XMLSerializer serializer2 = new XMLSerializer(typeof(List<Animal>));
                serializer2.Serialize(fs, theAnimals);

            }
            theAnimals = null;

            XMLSerializer serializer3 = new XMLSerializer(typeof(List<Animal>));

            
            using (FileStream fs2 = new FileStream(@"D:\Bizruntime\Xml_Documentation\Xml_Serialize.xml", FileMode.Open, FileAccess.Read))
            {
                theAnimals =(List<Animal>)serializer3.Deserializer(fs2);
            }

            foreach (Animal a in theAnimals)
            {
                Log.Info(a.ToString());
            }
        
        }
    }
}
