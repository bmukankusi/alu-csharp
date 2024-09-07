using System;

class Program
{
    public static void PrintLine(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write("_");
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        PrintLine(10);
    }
}