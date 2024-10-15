using System.Collections.Generic;
using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        [Test]
        public void Max_WithNonEmptyList_ReturnsMaxValue()
        {
            // Arrange
            var nums = new List<int> { 1, 3, 2, 5, 4 };

            // Act
            int result = Operations.Max(nums);

            // Assert
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Max_WithEmptyList_ReturnsZero()
        {
            // Arrange
            var nums = new List<int>();

            // Act
            int result = Operations.Max(nums);

            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Max_WithNullList_ReturnsZero()
        {
            // Arrange
            List<int> nums = null;

            // Act
            int result = Operations.Max(nums);

            // Assert
            Assert.AreEqual(0, result);
        }
    }
}