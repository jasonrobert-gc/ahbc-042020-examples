using System;
using System.Collections.Generic;
using System.Text;

namespace Class14
{
    public interface IPrey : IAnimal
    {
        IPredator[] GetPredators();
    }
}
