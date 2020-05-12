using System;
using System.Collections.Generic;
using System.Text;

namespace Class13
{
    public class Employee
    {
        public virtual void Pay(int payAmount)
        {
            Console.WriteLine("Pay an employee");
        }
    }
}
