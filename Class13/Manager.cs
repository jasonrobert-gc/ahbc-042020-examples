using System;
using System.Collections.Generic;
using System.Text;

namespace Class13
{
    public class Manager : Employee
    {
        public override void Pay(int payAmount)
        {
            Console.WriteLine("Pay a Manager");
        }
    }
}
