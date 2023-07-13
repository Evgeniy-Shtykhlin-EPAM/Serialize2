using System.Xml.Serialization;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fileName = @"c:\temp\SerializationForTask2.txt";

            var person = new Person("Ivan", "Ivanov");


            var xmlSerializer = new XmlSerializer(typeof(Person));

            //serialization
            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, person);
                Console.WriteLine("Object has been serialized");
            }


            //deserialization
            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                var departmentDeserialized = xmlSerializer.Deserialize(fs) as Person;
                Console.WriteLine("Object has been deserialized");
            }

            Console.ReadLine(); ;
        }
    }
}