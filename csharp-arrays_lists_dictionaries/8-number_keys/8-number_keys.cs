﻿﻿using System;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int counter = 0;
        Dictionary<string,string>.KeyCollection keys = myDict.Keys;
        foreach(string key in keys)
        {
            counter++;
        }
        return counter;
        
    }
}