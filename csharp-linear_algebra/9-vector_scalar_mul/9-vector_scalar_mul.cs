/// <summary>
///THIS class contains methods for performing vector operations
/// </summary>
public class VectorMath{
    /// <summary>
/// Performs element-wise multiplication of a vector by a scalar value.
/// </summary>
/// <param name="vector">The vector to be multiplied.</param>
/// <param name="scalar">The scalar value to multiply by.</param>
/// <returns>A new vector containing the product of each element in the vector and the scalar.</returns>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length !=2 && vector.Length !=3){
            return new double[] {-1, -1, -1};
        }
        int dimension = vector.Length;
        double[] result = new double[dimension];

        for (int i = 0; i < dimension; i++)
        {
        result[i] = vector[i] * scalar;
        }

        return result;
    }
}