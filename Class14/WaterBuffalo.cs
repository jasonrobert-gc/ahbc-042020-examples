using System;
using System.Collections.Generic;
using System.Text;

namespace Class14
{
    public class WaterBuffalo : IPrey
    {
        public string Name => nameof(WaterBuffalo);

        public int Size => 10;

        public int GetNumberOfLegs()
        {
            return 4;
        }

        public IPredator[] GetPredators()
        {
            return new IPredator[]
            {
                new Lion()
            };
        }

        public void MakeSound()
        {
            Console.WriteLine("Mooooo");
        }
    }
}
