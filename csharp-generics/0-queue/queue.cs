using System;
using System.Collections.Generic;

///<summary>
///Generic class Queue
///</summary>
public class Queue<T>
{
    /// <summary>
    /// method for type checking of generic type
    /// </summary>
    /// <returns>type of generic type</returns>
    public Type CheckType()
    {
        return typeof(T);
    }
}

class Program
{
    static void Main()
    {
        Queue<int> queue = new Queue<int>();
        Console.WriteLine(queue.CheckType());
    }
}