using System;

class VectorMath
{
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if ((vector1.Length != 2 && vector1.Length != 3) || (vector2.Length != 2 && vector2.Length != 3) || (vector1.Length != vector2.Length))
            {
                return new double[] {-1};
            }

        double[] result = new double[vector1.Length];

        for (int i = 0; i < vector1.Length; i++)
        {
            result[i] = vector1[i] + vector2[i];
        }

        return result;
    }

    public static double[] Multiply(double[] vector, double scalar)
    {
        // Check if vector is 2D or 3D
        if (vector.Length != 2 && vector.Length != 3)
        {
        return new double[] { -1 }; // Return error vector
        }

        // Create a new vector to store the product
        double[] result = new double[vector.Length];

        // Multiply each element of the vector by the scalar
        for (int i = 0; i < vector.Length; i++)
        {
        result[i] = vector[i] * scalar;
        }

        return result;
    }

    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if ((vector1.Length != 2 && vector1.Length != 3) || (vector2.Length != 2 && vector2.Length != 3) || (vector1.Length != vector2.Length))
        {
            return -1;
        }

        double dotProduct = 0;
        for (int i = 0; i < vector1.Length; i++)
        {
            dotProduct += vector1[i] * vector2[i];
        }
        return dotProduct;
    }
}