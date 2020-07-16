using Class40.Models;

namespace Class40.Services
{
    /// <summary>
    /// SOLID - Single Responsiblity Principle (SRP) - MathService is only responsible for math.  Doesn't care about 
    /// anything else.
    /// </summary>
    public class MathService : IMathService
    {
        private CalculateRequest _lastRequest;

        public CalculateResult Calculate(CalculateRequest request)
        {
            /* Object initialization

            this...

            var test = new CalculateResult();
            test.Result = 1234;

            is the same as this...

            var test = new CalculateResult { Result = 1234 };

            */

            _lastRequest = request;

            switch (request.Type)
            {
                case CalculateType.Add:
                    return new CalculateResult { Result = request.FirstNumber + request.SecondNumber };
                case CalculateType.Subtract:
                    return new CalculateResult { Result = request.FirstNumber - request.SecondNumber };
                case CalculateType.Multiply:
                    return new CalculateResult { Result = request.FirstNumber * request.SecondNumber };
                case CalculateType.Divide:
                    return new CalculateResult { Result = request.FirstNumber / request.SecondNumber };
                default:
                    return null;
            }
        }

        public CalculateRequest GetLastRequest()
        {
            return _lastRequest;
        }
    }
}
