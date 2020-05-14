using System;

namespace Bonus13
{
    public abstract class MagicUsingCharacter : GameCharacter
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

        //// It is not required (but it can optionally) to override the abstract method here
        //// BECAUSE it is an abstract class itself.  It will pass this responsiblity
        //// to its child class.
        //public override void Move(int x, int y)
        //{

        //}
    }
}
