namespace Employee_Management_System_SOLID_Principles.Interface_Segregation_Principle__ISP_
{
    internal class Manager : IWorkable, IReportable
    {
        public void GenerateReport()
        {
            Console.WriteLine("Manager is generating a report.");
        }

        public void Work()
        {
            Console.WriteLine("Manager is Working in Manage Employees");
        }
    }
}
