using System;
using System.Collections.Generic;
using System.Text;

namespace Class11
{
    public class Pizza
    {
        // Static field
        public static int Cost = 100;

        // Referred to as a private field.
        // Fields are what we call class level variables
        // Conventions tell use to use camel case with and underscore
        private string _type;

        /// <summary>
        /// Constructor.  No return type.  Called when an object is created.
        /// </summary>
        public Pizza(string type)
        {
            _type = type;
        }

        /// <summary>
        /// This is a NON static method which will display the _type associated with
        /// this specific instance (object).
        /// </summary>
        public void Eat()
        {
            Console.WriteLine($"This is a yummy {_type} pizza. nom nom nom.");
        }
    }
}
