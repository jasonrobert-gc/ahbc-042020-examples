using System;
using System.Collections.Generic;
using System.Text;

namespace Class14
{
    public class Lion : IPredator
    {
        public string Name => "Lion";

        public int Size => 7;

        public int GetNumberOfLegs()
        {
            return 4;
        }

        public IPrey[] GetPrey()
        {
            return new IPrey[]
            {
                new WaterBuffalo()
            };
        }

        public void MakeSound()
        {
            Console.WriteLine("ROAR!");
        }
    }
}
