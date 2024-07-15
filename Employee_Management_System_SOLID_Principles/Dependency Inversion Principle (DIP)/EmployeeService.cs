using Employee_Management_System_SOLID_Principles.Single_Responsibility_Principle__SRP_;

namespace Employee_Management_System_SOLID_Principles.Dependency_Inversion_Principle__DIP_
{
    internal class EmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public void AddNewEmployee(Employee employee)
        {
            _employeeRepository.AddEmployee(employee);
        }
        public Employee FindEmployeeByName(string name)
        {
            return _employeeRepository.GetEmployeeByName(name);
        }
    }
}
