using System;

namespace Bonus13
{
    public class MagicUsingCharacter : GameCharacter
    {
        public MagicUsingCharacter(string name, int strength, int intelligence, int magicalEnergy)
            : base(name, strength, intelligence)
        {
            MagicalEnergy = magicalEnergy;
        }

        public int MagicalEnergy { get; }

        public override void Play()
        {
            base.Play();
            Console.WriteLine($"MagicalEnergy = {MagicalEnergy}");
        }
    }
}
