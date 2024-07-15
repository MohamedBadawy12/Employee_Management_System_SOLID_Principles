namespace Employee_Management_System_SOLID_Principles.Liskov_Substitution_Principle__LSP_
{
    internal abstract class EmployeeBase
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public EmployeeBase(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public abstract void Work();
    }
}
