using Class29;
using Xunit;

namespace Class29UnitTests
{
    public class FizzBuzzWoofTests
    {
        [Theory]
        [InlineData(3, "Fizz")]
        [InlineData(13, "Fizz")]
        [InlineData(9, "Fizz")]
        [InlineData(12, "Fizz")]
        [InlineData(15, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(10, "Buzz")]
        [InlineData(51, "Buzz")]
        [InlineData(50, "Buzz")]
        [InlineData(25, "Buzz")]
        [InlineData(7, "Woof")]
        [InlineData(14, "Woof")]
        [InlineData(21, "Woof")]
        [InlineData(27, "Woof")]
        [InlineData(35, "FizzBuzzWoof")]
        public void LotsOfFizzBuzzWoofTests(int input, string expected)
        {
            // Arrange
            var sut = new FizzBuzzWoof();

            // Act
            var result = sut.GetDisplayValue(input);

            // Assert
            Assert.Contains(expected, result);
        }

        [Fact]
        public void FizzGetsReturnedWhenMultipleOfThree()
        {
            // Arrange
            var sut = new FizzBuzzWoof();

            // Act
            var result = sut.GetDisplayValue(3);

            // Assert
            Assert.Contains("Fizz", result);
        }

        [Fact]
        public void FizzGetsReturnedWhenContainsThree()
        {
            // Arrange
            var sut = new FizzBuzzWoof();

            // Act
            var result = sut.GetDisplayValue(13);

            // Assert
            Assert.Contains("Fizz", result);
        }

        [Fact]
        public void FizzDoesntGetReturnedWhenItShouldnt()
        {
            // Arrange
            var sut = new FizzBuzzWoof();

            // Act
            var result = sut.GetDisplayValue(5);

            // Assert
            Assert.DoesNotContain("Fizz", result);
        }

        [Fact]
        public void BuzzGetsReturnedWhenMultipleOfFive()
        {
            // Arrange
            var sut = new FizzBuzzWoof();

            // Act
            var result = sut.GetDisplayValue(5);

            // Assert
            Assert.Contains("Buzz", result);
        }

        [Fact]
        public void BuzzGetsReturnedWhenContainsFive()
        {
            // Arrange
            var sut = new FizzBuzzWoof();

            // Act
            var result = sut.GetDisplayValue(51);

            // Assert
            Assert.Contains("Buzz", result);
        }

        [Fact]
        public void BuzzDoesntGetReturnedWhenItShouldnt()
        {
            // Arrange
            var sut = new FizzBuzzWoof();

            // Act
            var result = sut.GetDisplayValue(3);

            // Assert
            Assert.DoesNotContain("Buzz", result);
        }

        [Fact]
        public void WoofGetsReturnedWhenMultipleOfSeven()
        {
            // Arrange
            var sut = new FizzBuzzWoof();

            // Act
            var result = sut.GetDisplayValue(7);

            // Assert
            Assert.Contains("Woof", result);
        }

        [Fact]
        public void WoofGetsReturnedWhenContainsSeven()
        {
            // Arrange
            var sut = new FizzBuzzWoof();

            // Act
            var result = sut.GetDisplayValue(71);

            // Assert
            Assert.Contains("Woof", result);
        }

        [Fact]
        public void WoofDoesntGetReturnedWhenItShouldnt()
        {
            // Arrange
            var sut = new FizzBuzzWoof();

            // Act
            var result = sut.GetDisplayValue(5);

            // Assert
            Assert.DoesNotContain("Woof", result);
        }

        [Fact]
        public void FizzBuzzWoofGetsReturnedWhenItShould()
        {
            // Arrange
            var sut = new FizzBuzzWoof();

            // Act
            var result = sut.GetDisplayValue(35);

            // Assert
            Assert.Equal("FizzBuzzWoof", result);
        }
    }
}
