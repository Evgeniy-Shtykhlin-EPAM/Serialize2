using System.Runtime.Serialization;

namespace Task2
{
    [Serializable]
    public class Person:ISerializable
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public Person()
        {
            
        }

        public Person(string name, string lastName)
        {
            Name=name;
            LastName=lastName;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", this.Name);
            info.AddValue("LastName", this.LastName);
        }
    }
}
