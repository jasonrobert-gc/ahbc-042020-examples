using System;

namespace Class13
{
    public class Manager : Employee
    {
        public sealed override void Pay(int payAmount)
        {
            Console.WriteLine("Pay a Manager");
        }
    }
}
