using System;
class MatrixMath
{
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        // Get the dimensions of the matrix
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Check if the matrix is either 2D (2x2, 2x3) or 3D (3x3)
        if ((rows == 2 && (cols == 2 || cols == 3)) || (rows == 3 && cols == 3))
        {
            // Initialize the resulting matrix
            double[,] result = new double[rows, cols];

            // Multiply each element by the scalar
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix[i, j] * scalar;
                }
            }

            return result;
        }
        else
        {
            return new double[,] { { -1 } };
        }
    }
}