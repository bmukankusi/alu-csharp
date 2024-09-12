using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<string> keys = new List<string>(myDict.Keys);
        keys.Sort();

        foreach (string key in keys)
        {
            Console.WriteLine($"{key}: {myDict[key]}");
        }
    }

    static void Main(string[] args)
    {
        Dictionary<string, string> myDict = new Dictionary<string, string>
        {
            { "language", "C" },
            { "track", "low level" },
            { "school", "Holberton" },
            { "address", "972 Mission St." },
            { "city", "San Francisco" }
        };

        PrintSorted(myDict);
    }
}