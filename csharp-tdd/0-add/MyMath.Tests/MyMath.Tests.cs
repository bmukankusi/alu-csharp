using NUnit.Framework;
using MyMath;

namespace MyMath.Tests {
    /// <summary>
    /// Contains unit tests for the Operations class.
    /// </summary>
    public class OperationsTests {
        /// <summary>
        /// Tests the Add method to ensure it correctly adds two integers.
        /// </summary>
        [Test]
        public void Add_AddsTwoIntegers_ReturnsSum() {
            Assert.AreEqual(5, Operations.Add(2, 3));
        }
    }
}