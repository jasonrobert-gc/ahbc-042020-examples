using System;

namespace Bonus13
{
    public class Wizard : MagicUsingCharacter
    {
        public Wizard(string name, int strength, int intelligence, int magicalEnergy, int spellNumber)
            : base(name, strength, intelligence, magicalEnergy)
        {
            SpellNumber = spellNumber;
        }

        public int SpellNumber { get; }

        public override void Play()
        {
            base.Play();
            Console.WriteLine($"SpellNumber = {SpellNumber}");
        }
    }
}
