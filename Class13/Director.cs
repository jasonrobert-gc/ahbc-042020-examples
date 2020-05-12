using System;
using System.Collections.Generic;
using System.Text;

namespace Class13
{
    public class Director : Employee
    {
        public Employee[] Employees { get; set; }

        public override void Pay(int payAmount)
        {
            Console.WriteLine("Pay a Director");
        }
    }
}
