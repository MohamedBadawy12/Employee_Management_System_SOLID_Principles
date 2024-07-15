using Employee_Management_System_SOLID_Principles.Single_Responsibility_Principle__SRP_;

namespace Employee_Management_System_SOLID_Principles.Open_Closed_Principle__OCP_
{
    internal abstract class EmployeeSpecification
    {
        public abstract bool IsSatisfiedBy(Employee employee);
    }
}
