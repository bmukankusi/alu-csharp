using System;
using System.Collections.Generic;

class Program
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0) {
            Console.WriteLine("Size cannot be negative");
            return new List<int>(); 
        }
        if (size == 0) {
            Console.WriteLine();    
        }
        List<int> list = new List<int>(size);
        for (int i = 0; i < size; i++)
        {
            list.Add(i);
        }
        for (int j = 0; j < size; j++) {
            if (j == size - 1) {
                Console.Write(list[j] + "\n");
            } else {
                Console.Write(list[j] + " ");
            }
        }
        return list;
    }

    static void Main(string[] args)
    {
        
        CreatePrint(10);
    }
}