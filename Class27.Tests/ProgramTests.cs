using System.Collections.Generic;
using Xunit;

namespace Class27.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void LinearSearchNotFoundReturnsFalse()
        {
            // Arrange
            var list = new List<int>
            {
                1,
                2,
                3
            };
            var searchValue = 4;

            // Act
            var result = Class27.Program.LinearSearch(list, searchValue);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void LinearSearchSortedFoundReturnsTrue()
        {
            // Arrange
            var list = new List<int>
            {
                1,
                2,
                3
            };
            var searchValue = 3;

            // Act
            var result = Class27.Program.LinearSearch(list, searchValue);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void LinearSearchUnsortedFoundReturnsTrue()
        {
            // Arrange
            var list = new List<int>
            {
                2,
                3,
                1,
            };
            var searchValue = 3;

            // Act
            var result = Class27.Program.LinearSearch(list, searchValue);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void LinearSearchEmptyListReturnsFalse()
        {
            // Arrange
            var list = new List<int>();
            var searchValue = 3;

            // Act
            var result = Class27.Program.LinearSearch(list, searchValue);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void LinearSearchNullListReturnsFalse()
        {
            // Arrange
            var searchValue = 3;

            // Act
            var result = Class27.Program.LinearSearch(null, searchValue);

            // Assert
            Assert.False(result);
        }
    }
}
