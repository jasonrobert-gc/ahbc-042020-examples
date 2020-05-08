using System;
using System.Collections.Generic;
using System.Text;

namespace Class12
{
    /// <summary>
    /// We might refer to this as a child class
    /// </summary>
    public class Employee : Person
    {
        //public string FirstName { get; set; }
        //public string LastName { get; set; }

        //public string GetFullName()
        //{
        //    return $"{FirstName} {LastName}";
        //}

        // Typically you will see PRIVATE class variables
        // Also referred to as a fields.
        private int _someInternalNumber;

        // Typically you will see PUBLIC properties.
        public int EmployeeNumber { get; set; }

        protected int Salary { get; set; }
    }
}
