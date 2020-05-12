using System;

namespace Bonus13
{
    class Program
    {
        static void Main(string[] args)
        {
            // We create a GameCharater Array (base class) and assign child class objects to it.
            // This is an example of polymorphism.
            var players = new GameCharacter[]
            {
                new Warrior("Utred", 7, 2, "Sword"),
                new Warrior("Ragnar", 5, 4, "Axe"),
                new Wizard("Flora", 2, 7, 8, 1),
                new Wizard("Fauna", 2, 8, 7, 2),
                new Wizard("Merryweather", 2, 8, 7, 3)
            };

            for (int i = 0; i < players.Length; i++)
            {
                // This is the essense of Polymorphism.  We can treat these as their parent (or base) class.
                GameCharacter character = players[i];

                // But that doesn't change what they are... Warriors are always warriors.  So the instantiated type (the child class)
                // is the one thats method is called.
                character.Play();
            }
        }
    }
}
