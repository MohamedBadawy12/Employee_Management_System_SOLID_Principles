namespace Employee_Management_System_SOLID_Principles.Single_Responsibility_Principle__SRP_
{
    internal class EmployeeRepository
    {
        private List<Employee> employees = new List<Employee>();
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }
        public void RemoveEmployee(Employee employee)
        {
            employees.Remove(employee);
        }
        public Employee FindEmployeeByName(string name)
        {
            return employees.FirstOrDefault(e => e.Name == name);
        }
    }
}
