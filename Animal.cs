using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    /// <summary>
    /// serialization
    /// </summary>
    [Serializable]
    public class Animal : ISerializale
    {
        /// <summary>
        /// Name attribute get and set
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Weight attribute get and set
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// Height attribute get and set
        /// </summary>
        public double Height { get; set; }
        /// <summary>
        /// AnimalID attribute get and set
        /// </summary>
        public int AnimalID { get; set; }

        /// <summary>
        /// constructor of Animal class
        /// </summary>
        public Animal() { }
        /// <summary>
        /// parameter constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="weight"></param>
        /// <param name="height"></param>
        public Animal(string name = "No Name", double weight = 0, double height = 0)
        {
            Name = name;
            Weight = weight;
            Height = height;
        }
        /// <summary>
        /// getting the content
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0} weight {1} lbs and is {2} inches tall", Name, Weight, Height);
        }


        /// <summary>
        /// Serialization
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("Weight", Weight);
            info.AddValue("Height", Height);
        }

        /// <summary>
        /// Deserialization
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        public Animal(SerializationInfo info, StreamingContext context)
        {
            Name = (string)info.GetValue("Name", typeof(string));
            Weight = (double)info.GetValue("Weight", typeof(double));
            Height = (double)info.GetValue("Height", typeof(double));
        }
    }
}

