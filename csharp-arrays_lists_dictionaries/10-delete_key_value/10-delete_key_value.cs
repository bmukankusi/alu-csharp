using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, string> DeleteKeyValue(Dictionary<string, string> myDict, string key)
    {
        if (myDict.ContainsKey(key))
        {
            myDict.Remove(key);
        }
        return myDict;
    }

    static void Main(string[] args)
    {
        Dictionary<string, string> myDict = new Dictionary<string, string>
        {
            { "key1", "value1" },
            { "key2", "value2" },
            { "key3", "value3" }
        };

        myDict = DeleteKeyValue(myDict, "key2");

        foreach (var kvp in myDict)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}