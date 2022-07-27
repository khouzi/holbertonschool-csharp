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
        public T value { get; set; }
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
        }
        else
        {
            tail.next = n;
            tail = n;
        }
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

    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
        {
            T k = head.value;
            head = head.next;
            count--;
            return (k);
        }
    }

    public T Peek()
    {
        if ( head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
        {
            return head.value;
        }
    }

    public void Print()
    {
        if ( head == null)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            while (head != null)
            {
                Console.WriteLine(head.value);
                head = head.next;
            }
        }
    }

    public T Concatenate()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        if (CheckType() == typeof(Char))
        {
            string k ="";
            while (head != null)
            {
                k += head.value;
                head = head.next;
            }
            Console.Write(k);
        }

        if (CheckType() == typeof(String))
        {
            string k ="";
            while (head != null)
            {
                k += head.value;
                if (head.next != null)
                {
                    k += " " ;
                }
                head = head.next;
            }
            Console.Write(k);
        }
        else
        {
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars only");
        }
        return(default(T));
    }
}
