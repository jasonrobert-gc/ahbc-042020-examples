using Class40.Models;
using System;

namespace Class40.Services
{
    /// <summary>
    /// SOLID - Open Closed Principle (OCP) - We can now EXTEND our application by creating new implementations of IMathService.
    /// We do not have to MODIFY our implementations directly.
    /// 
    /// SOLID - !Liskov Substitution Principle (LSP) - We are NOT following LSP here as the child class
    /// is not appropriately adhering to the interface.
    /// </summary>
    public class SlightlyBetterMathService : IMathService
    {
        public CalculateResult Calculate(CalculateRequest request)
        {
            throw new NotImplementedException();
        }

        public CalculateRequest GetLastRequest()
        {
            throw new NotImplementedException();
        }
    }
}
