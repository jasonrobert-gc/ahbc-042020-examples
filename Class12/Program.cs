using System;

namespace Class12
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee();
            employee.FirstName = "Jason";
            employee.LastName = "Robert";
            employee.EmployeeNumber = 12342;
            Console.WriteLine(employee.GetFullName());

            var contractor = new Contractor();
            contractor.FirstName = "Dafy";
            contractor.LastName = "Duck";
            // EmployeeNumber is not avail here
            Console.WriteLine(contractor.GetFullName());
        }
    }
}
