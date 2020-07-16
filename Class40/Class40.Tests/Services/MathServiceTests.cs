using Class40.Models;
using Class40.Services;
using Xunit;

namespace Class40.Tests.Services
{
    public class MathServiceTests
    {
        [Fact]
        public void Add_Should_Add()
        {
            // Arrange
            var request = new CalculateRequest
            {
                FirstNumber = 1,
                SecondNumber = 2,
                Type = CalculateType.Add
            };

            // Act
            var sut = new MathService();
            var result = sut.Calculate(request);

            // Assert
            Assert.Equal(3, result.Result);
        }
    }
}
