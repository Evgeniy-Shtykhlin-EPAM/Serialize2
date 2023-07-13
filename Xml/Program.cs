using System.Xml.Serialization;
using ClassLibrary;

namespace Xml
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fileName = @"c:\temp\xmlSerialization.xml";

            var employees = new List<Employee> { new Employee("AndreyXML"), new Employee("VasiliiXML"), new Employee("EgorXML") };
            var department = new Department("GeneralXML", employees);

            //serialization
            var xmlSerializer = new XmlSerializer(typeof(Department));
            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, department);
                Console.WriteLine("Object has been serialized");
            }


            //deserialization
            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                var departmentDeserialized = xmlSerializer.Deserialize(fs) as Department;
                Console.WriteLine("Object has been deserialized");
            }

            Console.ReadLine();
        }
    }
}