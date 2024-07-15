using Employee_Management_System_SOLID_Principles.Single_Responsibility_Principle__SRP_;

namespace Employee_Management_System_SOLID_Principles.Dependency_Inversion_Principle__DIP_
{
    internal interface IEmployeeRepository
    {
        void AddEmployee(Employee employee);
        Employee GetEmployeeByName(string name);
    }
}
