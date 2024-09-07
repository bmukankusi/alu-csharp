using System;

class Program
{
    public static void PrintDiagonal(int length)
    {
        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("\\");
        }
    }

    static void Main(string[] args)
    {
        PrintDiagonal(15);
    }
}