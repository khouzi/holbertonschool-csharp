using System;
///<summary>
/// class Queue
/// </summary>
/// <typeparam name="T"></typeparam>//

class Queue<T>
{
   public Node head { get; set; }
   public Node tail { get; set; }
   int count;

   public class Node
    {
        private T value { get; set; }
        public Node next { get; set; }
        public Node(T value)
        {
            this.value = value;
        }
    }

    public void Enqueue(T value)
    {
        Node n = new Node(value);
        if (count == 0)
        {
            head = n;
            tail = n;
            head.next = null;
        }
        else
            tail.next = n;
        count += 1;
    }

    public int Count()
    {
        return this.count;
    }
    
    public Type CheckType()
    {
        return typeof(T);
    }
}
