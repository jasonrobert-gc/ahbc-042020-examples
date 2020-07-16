using Class40.Models;

namespace Class40.Services
{
    public interface IMathService
    {
        CalculateResult Calculate(CalculateRequest request);

        CalculateRequest GetLastRequest();
    }
}