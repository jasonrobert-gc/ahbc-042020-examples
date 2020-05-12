using System;

namespace Class13
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new Manager();
            var director = new Director();
            var srManager = new SeniorManager();
            
            PayEmployee(manager, 10);
            PayEmployee(director, 15);
            PayEmployee(srManager, 13);
        }

        static void PayEmployee(Employee employee, int amount)
        {
            // While we can only access our object AS an employee.  It is still in fact a Manage/Director and as such, 
            // the corresponding child class methods will be invoked.
            employee.Pay(amount);
        }

        // We don't need these classes below because we can treat an Manager/Director as an Employee (Polymorphism)
        //static void PayEmployee(Manager employee, int amount)
        //{
        //    employee.Pay(amount);
        //}

        //static void PayEmployee(Director employee, int amount)
        //{
        //    employee.Pay(amount);
        //}
    }
}
