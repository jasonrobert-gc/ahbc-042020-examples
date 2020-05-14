using System;
using System.Collections.Generic;
using System.Text;

namespace Class14
{
    public class Frog : IPrey
    {
        public string Name => "Frog";

        public int Size => 2;

        public int GetNumberOfLegs()
        {
            return 4;
        }

        public IPredator[] GetPredators()
        {
            return null;
        }

        public void MakeSound()
        {
            Console.WriteLine("Riiiiiiibit");
        }
    }
}
