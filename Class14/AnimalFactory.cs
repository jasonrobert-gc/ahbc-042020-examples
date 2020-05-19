using System;
using System.Collections.Generic;
using System.Text;

namespace Class14
{
    public class AnimalFactory
    {
        public IAnimal Create(string animalType)
        {
            if (animalType.Equals("Frog", StringComparison.OrdinalIgnoreCase))
            {
                return new Frog();
            }
            else if (animalType.Equals("WaterBuffalo", StringComparison.OrdinalIgnoreCase))
            {
                return new WaterBuffalo();
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(animalType), "Animal type not supported!");
            }
        }
    }
}
