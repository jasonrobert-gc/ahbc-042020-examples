using System;
using System.Collections.Generic;
using System.Text;

namespace Class12
{
    public class Manager : Employee
    {
        public void SomeMeTheMoney()
        {
            // Salary is available in the child classes
            // BUT private _someinternanumber is not.

            // Console.WriteLine(_someInternalNumber);
            Console.WriteLine(Salary);
        }
    }
}
