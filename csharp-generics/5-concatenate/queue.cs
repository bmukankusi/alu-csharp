using System;
using System.Text;

/// <summary>
/// Represents a generic queue.
/// </summary>
/// <typeparam name="T">The type of elements in the queue.</typeparam>
public class Queue<T>
{
    public class Node
    {
        public T? Value { get; set; }
        public Node? Next { get; set; }
        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }

    private Node? head;
    private Node? tail;
    private int count;

    public Queue()
    {
        head = null;
        tail = null;
        count = 0;
    }

    public void Enqueue(T value)
    {
        Node newNode = new Node(value);
        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail!.Next = newNode;
            tail = newNode;
        }
        count++;
    }

    public string? Concatenate()
    {
        if (count == 0)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }

        if (typeof(T) != typeof(string) && typeof(T) != typeof(char))
        {
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
            return null;
        }

        StringBuilder result = new StringBuilder();
        Node? current = head;
        while (current != null)
        {
            result.Append(current.Value);
            if (typeof(T) == typeof(string) && current.Next != null)
                result.Append(" ");
            current = current.Next;
        }

        return result.ToString();
    }
}
