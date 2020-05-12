using System;
using System.Collections.Generic;
using System.Text;

namespace Class12
{
    /// <summary>
    /// We might refer to this as a (base or parent)
    /// </summary>
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
