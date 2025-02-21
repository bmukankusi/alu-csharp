/// <summary>
/// Generic class Queue that creates a new Queue
/// </summary>
/// <typeparam name="T"></typeparam>
using System;

public class Queue<T>
{
  /// <summary>
  /// Head of the Queue
  /// </summary>
  public Node? head;
  /// <summary>
  /// Tail of the Queue
  /// </summary>
  public Node? tail;
  /// <summary>
  /// Count of the Nodes
  /// </summary>
  public int count;
  /// <summary>
  /// The Node class
  /// </summary>
  public class Node
  {
    /// <summary>
    /// Value of a node 
    /// </summary>
    public T? value = default;
    /// <summary>
    /// Next pointer of a node 
    /// </summary>
    public Node? next = null;
    /// <summary>
    /// The constructor of the Node class
    /// </summary>
    /// <param name="v"></param>
    public Node(T v)
    {
      value = v;
      next = null;
    }

  }
  /// <summary>
  /// Method that returns the type of the Queue
  /// A method that returns the type of the Queue
  /// </summary>
  /// <returns> The type of the Queue </returns>
  public Type CheckType()
  {
    return typeof(T);
  }

  /// <summary>
  /// Method that adds an item to the queue
  /// </summary>
  /// <param name="value"></param>
  public void Enqueue(T? value)
  {
    Node newNode = new Node(value!);
    if (head == null)
    {
      head = newNode;
      tail = newNode;
    }
    else
    {
      tail!.next = newNode;
      tail = newNode;
    }
    count++;
  }
  /// <summary>
  /// A method to remove the first element in the queue
  /// </summary>
  /// <returns> The value of the node </returns>
  public T Dequeue()
  {
    if (head == null)
    {
      Console.WriteLine("Queue is empty");
      return default(T)!;
    }
    else
    {
      Node current = head;
      head = current.next;
      count--;
      return current!.value!;
    }
  }
  /// <summary>
  /// A method to return the first element in th queue
  /// </summary>
  /// <returns></returns>
  public T Peek()
  {
    if (head == null)
    {
      Console.WriteLine("Queue is empty");
      return default(T)!;
    }
    else
    {
      return head.value!;
    }
  }
  /// <summary>
  /// A method to Print the elements
  /// </summary>
  public void Print()
  {
    if (head == null)
    {
      Console.WriteLine("Queue is empty");
    }
    else
    {
      do
      {
        Console.WriteLine(head.value);
        head = head.next;
      }
      while (head!.next != null);
      Console.WriteLine(head.value);
    }
  }
  /// <summary>
  /// Method to concatenate the contents of a queue
  /// </summary>
  /// <returns></returns>
  public string Concatenate()
  {
    if (head == null)
    {
      Console.WriteLine("Queue is empty");
      return null!;
    }
    else
    {
      if (CheckType() == typeof(string) || CheckType() == typeof(char))
      {
        string newString = "";
        do
        {
          newString += head.value + " ";
          head = head.next;
        }
        while (head!.next != null);
        newString += head.value;
        return newString;
      }
      else
      {
        Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
        return null!;
      }
    }
  }
  /// <summary>
  /// Method to count all the nodes of a queue
  /// </summary>
  /// <returns></returns>
  public int Count()
  {
    return count;
  }
}

class Program
{
  static void Main(string[] args)
  {
    Queue<string> myQueue = new Queue<string>();
    myQueue.Enqueue("Hello");
    myQueue.Enqueue("World");
    myQueue.Enqueue("!");
    Console.WriteLine(myQueue.Concatenate());
  }
}