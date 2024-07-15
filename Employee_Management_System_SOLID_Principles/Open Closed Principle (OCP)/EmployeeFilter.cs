using Employee_Management_System_SOLID_Principles.Single_Responsibility_Principle__SRP_;

namespace Employee_Management_System_SOLID_Principles.Open_Closed_Principle__OCP_
{
    internal class EmployeeFilter
    {
        public IEnumerable<Employee> FilterSpecification(IEnumerable<Employee> employees, EmployeeSpecification spec)
        {
            return employees.Where(employee => spec.IsSatisfiedBy(employee));
        }
        public IEnumerable<Employee> FilterEmpSalary(IEnumerable<Employee> employees)
        {
            return employees.Where(employee => employee.Salary >= 3000);
        }
    }
}
