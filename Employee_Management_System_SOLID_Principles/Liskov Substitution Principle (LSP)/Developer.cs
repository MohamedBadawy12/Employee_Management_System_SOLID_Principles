namespace Employee_Management_System_SOLID_Principles.Liskov_Substitution_Principle__LSP_
{
    internal class Developer : EmployeeBase
    {
        public Developer(string name, int age) : base(name, age)
        {

        }

        public override void Work()
        {
            Console.WriteLine($"{Name}, the developer, is writing code.");
        }
    }
}
