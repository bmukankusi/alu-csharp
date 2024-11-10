/// <summary>
/// vector magnitude
/// </summary>
public class VectorMath
{
    /// <summary>
/// Calculates the magnitude (Euclidean norm) of a 2D or 3D vector.
/// </summary>
/// <param name="vector">The vector for which to calculate the magnitude.</param>
/// <returns>The magnitude of the vector, or -1 if the vector dimension is not 2 or 3.</returns>
    public static double Magnitude(double[] vector)
    {
        if (vector.Length != 2 && vector.Length != 3)
        {
        return -1; // Invalid vector dimension
        }

        double sum = 0;
        foreach (double element in vector)
        {
        sum += Math.Pow(element, 2); // Square each element
        }

        return Math.Round(Math.Sqrt(sum), 2); // Round to nearest hundredth
    }
}