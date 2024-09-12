using System;

class Program
{
    static void Main(string[] args)
    {
        
        int[][] jaggedArray = new int[3][];

        
        jaggedArray[0] = new int[] { 0, 1, 2, 3};
        jaggedArray[1] = new int[] { 0, 1, 2, 3, 4, 5, 6};
        jaggedArray[2] = new int[] { 0, 1};

         
        foreach (int[] array in jaggedArray)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}