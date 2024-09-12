using System;
using System.Collections.Generic;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (index < 0 || index >= myList.Count)
        {
            Console.WriteLine("Index is out of range");
            return myList;
        }

        List<int> updatedList = new List<int>();
        for (int i = 0; i < myList.Count; i++)
        {
            if (i != index)
            {
                updatedList.Add(myList[i]);
            }
        }

        return updatedList;
    }

    static void Main(string[] args)
    {
        List<int> myList = new List<int> { 1, 2, 3, 4, 5 };
        myList = DeleteAt(myList, 2);
        Console.WriteLine(string.Join(", ", myList));
    }
}