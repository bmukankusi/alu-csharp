using NUnit.Framework;
using System;

namespace MyMath.Tests
{
    /// <summary>
    /// Contains unit tests for the Matrix class.
    /// </summary>
    public class MatrixTests
    {
        /// <summary>
        /// Tests the Divide method with a valid matrix and number.
        /// </summary>
        [Test]
        public void Divide_ValidMatrixAndNumber_ReturnsDividedMatrix()
        {
            int[,] matrix = { { 2, 4 }, { 6, 8 } };
            int num = 2;
            int[,] expected = { { 1, 2 }, { 3, 4 } };

            int[,] result = Matrix.Divide(matrix, num);

            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Tests the Divide method with num equal to 0.
        /// </summary>
        [Test]
        public void Divide_NumIsZero_ReturnsNull()
        {
            int[,] matrix = { { 2, 4 }, { 6, 8 } };

            int[,] result = Matrix.Divide(matrix, 0);

            Assert.IsNull(result);
        }

        /// <summary>
        /// Tests the Divide method with a null matrix.
        /// </summary>
        [Test]
        public void Divide_MatrixIsNull_ReturnsNull()
        {
            int[,] result = Matrix.Divide(null, 2);

            Assert.IsNull(result);
        }
    }
}