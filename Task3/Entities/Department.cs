namespace Task3.Entities
{
    [Serializable]
    public class Department : ICloneable
    {
        public string DepartmentName { get; set; }
        public List<Employee> Employees { get; set; }

        public Department()
        {

        }

        public Department(string departmentName, List<Employee> employees)
        {
            DepartmentName = departmentName;
            Employees = employees;
        }

        public object Clone()
        {
            var cloned = new Department
            {
                DepartmentName = DepartmentName,
                Employees = Employees.ConvertAll(s => (Employee)s.Clone()).ToList()
            };
            return cloned;
        }
    }
}
