using System;
using System.Collections.Generic;

class Program
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> resultList = new List<bool>();
        foreach (int num in myList)
        {
            if (num % 2 == 0)
            {
                resultList.Add(true);
            }
            else
            {
                resultList.Add(false);
            }
        }
        return resultList;
    }

    static void Main(string[] args)
    {
        // Example usage
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
        List<bool> results = DivisibleBy2(numbers);
        foreach (bool result in results)
        {
            Console.WriteLine(result);
        }
    }
}