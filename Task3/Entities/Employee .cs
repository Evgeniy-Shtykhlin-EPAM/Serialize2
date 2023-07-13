namespace Task3.Entities
{
    [Serializable]
    public class Employee : ICloneable
    {
        public string EmployeeName { get; set; }

        public Employee()
        {

        }
        public Employee(string employeeName)
        {
            EmployeeName = employeeName;
        }
        public object Clone()
        {

            return new Employee
            {
                EmployeeName = EmployeeName
            };
        }
    }
}