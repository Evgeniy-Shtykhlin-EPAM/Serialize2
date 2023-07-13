namespace ClassLibrary
{
    [Serializable]
    public class Department
    {
        public string DepartmentName { get; set; }
        public List<Employee> Employees { get; set; }

        public Department()
        {
            
        }

        public Department(string departmentName, List<Employee> employees)
        {
            DepartmentName= departmentName;
            Employees = employees;
        }
    }
}
