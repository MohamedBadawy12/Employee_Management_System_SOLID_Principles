namespace Employee_Management_System_SOLID_Principles.Interface_Segregation_Principle__ISP_
{
    public class Developer : IWorkable
    {
        public void Work()
        {
            Console.WriteLine("Developer is working in code.");
        }
    }
}
