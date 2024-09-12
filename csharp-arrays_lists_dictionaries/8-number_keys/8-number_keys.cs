using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int keyCount = 0;
        foreach (var key in myDict.Keys)
        {
            keyCount++;
        }
        return keyCount;
    }

    static void Main(string[] args)
    {
        Dictionary<string, string> myDict = new Dictionary<string, string>
        {
            { "key1", "value1" },
            { "key2", "value2" },
            { "key3", "value3" }
        };

        int numberOfKeys = NumberOfKeys(myDict);
        Console.WriteLine("Number of keys: " + numberOfKeys);
    }
}