using Employee_Management_System_SOLID_Principles.Dependency_Inversion_Principle__DIP_;
using Employee_Management_System_SOLID_Principles.Liskov_Substitution_Principle__LSP_;
using Employee_Management_System_SOLID_Principles.Open_Closed_Principle__OCP_;
using Employee_Management_System_SOLID_Principles.Single_Responsibility_Principle__SRP_;

namespace Employee_Management_System_SOLID_Principles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEmployeeRepository employeeRepository = new Dependency_Inversion_Principle__DIP_.EmployeeRepository();
            EmployeeService employeeService = new EmployeeService(employeeRepository);

            Employee employee1 = new Employee("Mohamed", 25, "Developer", 15000);
            employeeService.AddNewEmployee(employee1);

            Employee employee2 = new Employee("Sara", 40, "Manager", 25000);
            employeeService.AddNewEmployee(employee2);

            Console.Write("Enter Name Of Employee To Search For:");
            string EmployeeName = Console.ReadLine();

            Employee foundEmployee = employeeService.FindEmployeeByName(EmployeeName);
            if (foundEmployee != null)
            {
                Console.WriteLine($"Found Employee: {foundEmployee.Name}, Position: {foundEmployee.Position}, Age: {foundEmployee.Age}, " +
                    $"Salary: {foundEmployee.Salary}");
            }
            Console.WriteLine("-----------------------------------------------------------");
            EmployeeFilter employeeFilter = new EmployeeFilter();
            AgeSpecification spec = new AgeSpecification(35);
            var employeesAbove35 = employeeFilter.FilterSpecification(new List<Employee> { employee1, employee2 }, spec);
            foreach (var employee in employeesAbove35)
            {
                Console.WriteLine($"Employee above 35: {employee.Name}");
            }
            List<EmployeeBase> employees = new List<EmployeeBase>
            {
                new Manager("Ahmed", 45),
                new Developer("Rana", 29),
            };
            foreach (var employee in employees)
            {
                employee.Work();
            }
            Interface_Segregation_Principle__ISP_.Developer developer = new Interface_Segregation_Principle__ISP_.Developer();
            developer.Work();
            Interface_Segregation_Principle__ISP_.Manager manager = new Interface_Segregation_Principle__ISP_.Manager();
            manager.Work();
            manager.GenerateReport();
        }
    }
}