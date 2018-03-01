using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    [Serializable()]
    class Serialization1
    {
        public string Type { get; set; }
        public int Number { get; set; }
        public bool Healthy { get; set; }

        public Serialization1(string t, int n, bool h)
        {
            Type = t;
            Number = n;
            Healthy = h;
        }



        static void Main()
        {
            while (true)
            {
                Console.WriteLine("s=serialize, r=read:");
                switch (Console.ReadLine())
                {
                    case "s":
                        var lizards1 = new List<Serialization1>();
                        lizards1.Add(new Serialization1("Thorny devil", 1, true));
                        lizards1.Add(new Serialization1("Casquehead lizard", 0, false));
                        lizards1.Add(new Serialization1("Green iguana", 4, true));
                        lizards1.Add(new Serialization1("Blotched blue-tongue lizard", 0, false));
                        lizards1.Add(new Serialization1("Gila monster", 1, false));

                        try
                        {
                            using (Stream stream = File.Open("data.bin", FileMode.Create))
                            {
                                BinaryFormatter bin = new BinaryFormatter();
                                bin.Serialize(stream, lizards1);
                            }
                        }
                        catch (IOException)
                        {
                        }
                        break;

                    case "r":
                        try
                        {
                            using (Stream stream = File.Open("data.bin", FileMode.Open))
                            {
                                BinaryFormatter bin = new BinaryFormatter();

                                var lizards2 = (List<Serialization1>)bin.Deserialize(stream);
                                foreach (Serialization1 lizard in lizards2)
                                {
                                    Console.WriteLine("{0}, {1}, {2}",
                                        lizard.Type,
                                        lizard.Number,
                                        lizard.Healthy);
                                }
                            }
                        }
                        catch (IOException)
                        {
                        }
                        break;
                }


            }
        }
    }
 }

