using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> nQueue, string newItem, string search)
    {
          Console.WriteLine($"Number of items: {nQueue.Count}");
        if (nQueue.Count  > 0)
            Console.WriteLine($"First item: {nQueue.Peek()}");
        else
            Console.WriteLine("Queue is empty");
        Console.WriteLine($"Queue contains \"{search}\": {nQueue.Contains(search)}");
        while (nQueue.Contains(search))
        {
            nQueue.Dequeue ();
        }
        nQueue.Enqueue(newItem);
        return nQueue;
    }
}