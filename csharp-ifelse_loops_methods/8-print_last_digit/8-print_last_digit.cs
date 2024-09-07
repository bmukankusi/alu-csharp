using System;

class Number 
{
    public static int PrintLastDigit(int number)
    {
        int lastDigit = number % 10;
        Console.Write(Math.Abs(lastDigit));
        return Math.Abs(lastDigit);
    }

    static void Main(string[] args)
    {
        // Example usage
        int number = -1234;
        PrintLastDigit(number);
    }
}