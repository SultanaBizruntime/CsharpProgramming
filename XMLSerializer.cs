using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp4
{
    internal class XMLSerializer
    {
        private Type type;

        public XMLSerializer(Type type)
        {
            this.type = type;
        }

        internal void Serialize(TextWriter tw, Animal a1)
        {
            throw new NotImplementedException();
        }

        internal object Deserializer()
        {
            throw new NotImplementedException();
        }

        internal object Deserializer(TextReader reader)
        {
            throw new NotImplementedException();
        }

        internal void Serialize(Stream fs, List<Animal> theAnimals)
        {
            throw new NotImplementedException();
        }

        internal List<Animal> Deserializer(FileStream fs2)
        {
            throw new NotImplementedException();
        }
    }
}