using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value)
    {
        myDict[key] = value;
        return myDict;
    }

    static void Main(string[] args)
    {
        Dictionary<string, string> myDict = new Dictionary<string, string>
        {
            { "key1", "value1" },
            { "key2", "value2" }
        };

        myDict = AddKeyValue(myDict, "key3", "value3");
        myDict = AddKeyValue(myDict, "key1", "newValue1");

        foreach (var kvp in myDict)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}