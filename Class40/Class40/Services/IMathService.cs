using Class40.Models;

namespace Class40.Services
{
    /// <summary>
    /// SOLID - Interface Segregation Principle (ISP) - We have a very small and focused interface.  Concerned only with 
    /// Math calculations. 
    /// </summary>
    public interface IMathService
    {
        CalculateResult Calculate(CalculateRequest request);

        CalculateRequest GetLastRequest();
    }
}