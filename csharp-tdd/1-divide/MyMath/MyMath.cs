using System;

namespace MyMath
{
    /// <summary>
    /// Provides methods for matrix operations.
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// Divides each element of the matrix by the specified number.
        /// </summary>
        /// <param name="matrix">The matrix to divide.</param>
        /// <param name="num">The number to divide by.</param>
        /// <returns>A new matrix with each element divided by the specified number.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the matrix is null.</exception>
        /// <exception cref="ArgumentException">Thrown when the number is zero.</exception>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
            {
                throw new ArgumentNullException(nameof(matrix), "Matrix cannot be null");
            }

            if (num == 0)
            {
                throw new ArgumentException("Num cannot be 0", nameof(num));
            }

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix[i, j] / num;
                }
            }

            return result;
        }
    }
}