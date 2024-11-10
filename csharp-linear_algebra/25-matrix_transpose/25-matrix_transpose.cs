/// <summary>
/// This class contains methods for performing operations on matrices.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Calculates the transpose of a matrix.
    /// The transpose is a new matrix created by swapping the rows and columns.
    /// </summary>
    /// <param name="matrix">The matrix for which to find the transpose.</param>
    /// <returns>A new matrix representing the transpose of the original matrix.</returns>
    public static double[,] Transpose(double[,] matrix)
    {
        if (matrix.Length == 0 || matrix.GetLength(0) == 0)
        {
        return new double[,] { }; // Empty matrix
        }

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        double[,] transposed = new double[cols, rows]; // Reversed dimensions for transpose

        for (int row = 0; row < rows; row++)
        {
        for (int col = 0; col < cols; col++)
        {
            transposed[col, row] = matrix[row, col]; // Swap row and column indices
        }
        }

        return transposed;
    }
}