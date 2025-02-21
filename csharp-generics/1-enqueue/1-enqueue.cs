/// <summary>
/// Generic class Queue that creates a queue of nodes
/// </summary>
/// <typeparam name="T"></typeparam>

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
    /// Count of the nodes in the queue
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
        /// Constructor
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
    /// </summary>
    /// <returns> The type of the Queue </returns>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary>
    /// Method that adds an item to the queue and increments the count
    /// </summary>
    /// <param name="value"></param>
    /// <returns> The value of the node </returns>
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
    /// Method to count all the nodes of a queue
    /// </summary>
    /// <returns> The count of the nodes </returns>
    public int Count()
    {
        return count;
    }
}