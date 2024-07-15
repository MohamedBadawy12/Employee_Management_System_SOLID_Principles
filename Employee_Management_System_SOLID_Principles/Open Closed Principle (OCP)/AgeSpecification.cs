using Employee_Management_System_SOLID_Principles.Single_Responsibility_Principle__SRP_;

namespace Employee_Management_System_SOLID_Principles.Open_Closed_Principle__OCP_
{
    internal class AgeSpecification : EmployeeSpecification
    {
        public readonly int minAge;
        public AgeSpecification(int minAge)
        {
            this.minAge = minAge;
        }
        public override bool IsSatisfiedBy(Employee employee)
        {
            return employee.Age >= minAge;
        }
    }
}
