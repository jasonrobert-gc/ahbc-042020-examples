using System;
using System.Collections.Generic;
using System.Text;

namespace Class14
{
    public interface IAnimal
    {
        string Name { get; }

        int Size { get; }

        void MakeSound();

        int GetNumberOfLegs();
    }
}
