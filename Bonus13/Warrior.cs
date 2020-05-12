using System;

namespace Bonus13
{
    public class Warrior : GameCharacter
    {
        /// <summary>
        /// I HAVE to provide the base class constructor parameters so, the base class constructor can be called.
        /// </summary>
        public Warrior(string name, int strength, int intelligence, string weaponType)
            : base(name, strength, intelligence)
        {
            WeaponType = weaponType;
        }

        public string WeaponType { get; }

        public override void Play()
        {
            // I don't have to call the base method BUT, it allows me to reuse the logic in that method.
            base.Play();
            Console.WriteLine($"WeaponType: {WeaponType}");
        }
    }
}
