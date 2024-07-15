namespace Employee_Management_System_SOLID_Principles.Single_Responsibility_Principle__SRP_
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public Employee(string name, int age, string position, decimal salary)
        {
            Name = name;
            Age = age;
            Position = position;
            Salary = salary;
        }
    }
}
