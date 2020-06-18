using System;
using Xunit;

namespace Class27UnitTests
{
    public class ProgramTests
    {
        [Fact]
        public void BubbleSortEmptyReturnsEmpty()
        {
            // Arrange
            var array = new int[0];

            // Act
            var result = Class27.Program.BubbleSort(array);

            // Assert
            Assert.Empty(result);
        }
    }
}
