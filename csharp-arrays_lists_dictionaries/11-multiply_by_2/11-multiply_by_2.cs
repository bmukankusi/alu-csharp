using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> newDict = new Dictionary<string, int>();

        foreach (var kvp in myDict)
        {
            newDict[kvp.Key] = kvp.Value * 2;
        }

        return newDict;
    }

    static void Main(string[] args)
    {
        Dictionary<string, int> myDict = new Dictionary<string, int>
        {
            { "a", 1 },
            { "b", 2 },
            { "c", 3 }
        };

        Dictionary<string, int> resultDict = MultiplyBy2(myDict);

        foreach (var kvp in resultDict)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}