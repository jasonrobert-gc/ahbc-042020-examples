using System;

namespace Bonus13
{
    public class GameCharacter
    {
        public GameCharacter(string name, int strength, int intelligence)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
        }

        public string Name { get; }
        public int Strength { get; }
        public int Intelligence { get; }

        public virtual void Play()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Intelligence: {Intelligence}");
        }
    }
}
