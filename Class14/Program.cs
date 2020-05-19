using System;

namespace Class14
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new AnimalFactory();
            IAnimal animal1 = factory.Create("Frog");
            IAnimal animal2 = factory.Create("WaterBuffalo");

            var result = WhoLives(animal1, animal2);

            Console.WriteLine($"The {result.Name} lives!");
            result.MakeSound();
        }

        static IAnimal WhoLives(IAnimal first, IAnimal second)
        {
            if (first is IPredator && second is IPrey)
            {
                Console.WriteLine($"{first.Name} eats {second.Name}");
                return first;
            }
            else if (second is IPredator && first is IPrey)
            {
                Console.WriteLine($"{second.Name} eats {first.Name}");
                return second;
            }

            if (first.Size > second.Size)
            {
                return first;
            }

            return second;
        }
    }
}
