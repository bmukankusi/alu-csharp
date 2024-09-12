using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList.Count == 0)
        {
            return "None";
        }

        string? bestKey = null;
        int highestScore = -1;

        foreach (var kvp in myList)
        {
            if (kvp.Value > highestScore)
            {
                highestScore = kvp.Value;
                bestKey = kvp.Key;
            }
        }

        return bestKey ?? "None";
    }

    static void Main(string[] args)
    {
        Dictionary<string, int> myList = new Dictionary<string, int>
        {
            { "Clover", 90 },
            { "Alex", 85 },
            { "Betty", 95 },
            { "Candice", 80 }
        };

        string bestStudent = BestScore(myList);
        Console.WriteLine("Best score: " + bestStudent);
    }
}