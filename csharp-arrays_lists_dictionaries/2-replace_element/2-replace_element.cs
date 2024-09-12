using System;

class Array
{
    public static int[] ReplaceElement(int[] array, int index, int n)
    {
        if (index < 0 || index >= array.Length)
        {
            Console.WriteLine("Index out of range");
            return array;
        }
        array[index] = n;
        return array;
    }

    static void Main(string[] args)
    {
        int[] myArray = { 1, 2, 3, 4, 5 };
        myArray = ReplaceElement(myArray, 2, 8);
        Console.WriteLine(string.Join(", ", myArray));
    }
}