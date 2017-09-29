using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DesignLibrary
{
    // Prototype Pattern

    [Serializable()]
    public abstract class IPrototype<T>
    {
        // Shallow copy
        public T Clone()
        {
            return (T)this.MemberwiseClone();
        }

        // Deep copy
        public T DeepCopy()
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, this);

            stream.Seek(0, SeekOrigin.Begin);

            T copy = (T)formatter.Deserialize(stream);

            stream.Close();

            return copy;
        }
    }

    [Serializable()]
    class DeeperData
    {
        public string Data { get; set; }

        public DeeperData(string s)
        {
            Data = s;
        }

        public override string ToString()
        {
            return Data;
        }
    }

    [Serializable()]
    class Prototype : IPrototype<Prototype>
    {
        public string Country { get; set; }
        public string Capital { get; set; }
        public DeeperData Language { get; set; }

        public Prototype(string country, string capital, string language)
        {
            Country = country;
            Capital = capital;
            Language = new DeeperData(language);
        }

        public override string ToString()
        {
            return Country + "\t\t" + Capital + "\t\t->" + Language;
        }
    }

    [Serializable()]
    class PrototypeManager : IPrototype<Prototype>
    {
        public Dictionary<string, Prototype> prototypes
            = new Dictionary<string, Prototype>
            {
                {"Germany",
                    new Prototype("Germany","Berlin","German")},
                {"Italy",
                new Prototype("Italy","Rome","Italian")},
                {"Australia",
                new Prototype("Australia","Canberra","English")}
            };
    }

    class PrototypeClient : IPrototype<Prototype>
    {
        static void Report(string s, Prototype a, Prototype b)
        {
            Console.WriteLine("\n" + s);
            Console.WriteLine("Prototype " + a + "\nClone " + b);
        }

        static void Main()
        {
            PrototypeManager manager = new PrototypeManager();
            Prototype c2, c3;

            // Copy Australia
            c2 = manager.prototypes["Australia"].Clone();
            Report("Shallow cloning Australia\n==============",
                manager.prototypes["Australia"], c2);

            // Changing Language
            c2.Language.Data = "Chinese";
            Report("Altering Clone deep state: prototype affected *****",
          manager.prototypes["Australia"], c2);

            // Copy Germany
            c3 = manager.prototypes["Germany"].DeepCopy();
            Report("Deep cloning Germany\n============",
                   manager.prototypes["Germany"], c3);

            // Change Capital
            c3.Capital = "Munich";
            Report("Altering Clone shallow state, prototype unaffected",
                      manager.prototypes["Germany"], c3);

            // Changing Language (deep data)
            c3.Language.Data = "Turkish";
            Report("Altering Clone deep state, prototype unaffected",
               manager.prototypes["Germany"], c3);
        }
    }
}
