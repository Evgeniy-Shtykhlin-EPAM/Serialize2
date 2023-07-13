using System.Text.Json;
using ClassLibrary;

namespace Json
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fileName = @"c:\temp\jsonSerialize.json";

            var employees = new List<Employee>
                { new Employee("AndreyJson"), new Employee("VasiliiJson"), new Employee("EgorJson") };
            var department = new Department("GeneralJson", employees);

            //serialization
            var json = JsonSerializer.Serialize(department);
            File.WriteAllText(fileName, json);


            //deserialization from json
            var restoredPerson = JsonSerializer.Deserialize<Department>(json);

            //deserialization from .json
            var jsonFromFile = File.ReadAllText(fileName);
            var departmentDeserialized = JsonSerializer.Deserialize<Department>(jsonFromFile);

            Console.ReadLine();
        }
    }
}