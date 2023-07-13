using System.Runtime.Serialization.Formatters.Binary;
using ClassLibrary;

namespace Binary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fileName = @"c:\temp\binarySerialization.txt";

            var employees = new List<Employee> { new Employee("AndreyBinary"), new Employee("VasiliiBinary"), new Employee("EgorBinary") };
            var department = new Department("GeneralBinary", employees);

            //serialization
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, department);
                Console.WriteLine("Object has been serialized");
            }

            //deserialization
            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                var departmentDeserialized = (Department)formatter.Deserialize(fs);

                Console.WriteLine("Object has been deserialized");
            }

            Console.ReadLine();
        }
    }
}