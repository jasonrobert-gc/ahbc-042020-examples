using System;
using System.Collections.Generic;
using System.Text;

namespace Class14b
{
    public abstract class Vehicle
    {
        public int CalculateMiles(int gasLeft)
        {
            return GetMpg() * gasLeft;
        }

        public abstract int GetMpg();
    }
}
