using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int rows = myMatrix.GetLength(0);
        int cols = myMatrix.GetLength(1);
        int[,] squaredMatrix = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                squaredMatrix[i, j] = myMatrix[i, j] * myMatrix[i, j];
            }
        }

        return squaredMatrix;
    }

    static void Main(string[] args)
    {
        int[,] myMatrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int[,] squaredMatrix = Square(myMatrix);

        for (int i = 0; i < squaredMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < squaredMatrix.GetLength(1); j++)
            {
                Console.Write(squaredMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}