using System;

class Number 
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    static void Main(string[] args)
    {
        // Example usage
        int result = Add(3, 4);
        Console.WriteLine("The sum is: " + result);
    }
}