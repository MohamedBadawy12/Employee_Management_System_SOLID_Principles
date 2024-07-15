using Employee_Management_System_SOLID_Principles.Single_Responsibility_Principle__SRP_;

namespace Employee_Management_System_SOLID_Principles.Dependency_Inversion_Principle__DIP_
{
    internal class EmployeeRepository : IEmployeeRepository
    {
        private List<Employee> employees = new List<Employee>();
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }
        public Employee GetEmployeeByName(string name)
        {
            return employees.FirstOrDefault(e => e.Name == name);
        }
    }
}
