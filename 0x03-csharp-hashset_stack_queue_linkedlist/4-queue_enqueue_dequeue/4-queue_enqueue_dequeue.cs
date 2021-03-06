using System;
using System.Collections.Generic;
class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Console.WriteLine("Number of items: {0}", aQueue.Count);
        if (aQueue.Count <= 0)
            Console.WriteLine("Queue is empty");
        else
        {
            string top_queue = aQueue.Peek();
            Console.WriteLine("First item: {0}", top_queue);
        }
        aQueue.Enqueue(newItem);
        if (aQueue.Contains(search) == true)
        {
            Console.WriteLine("Queue contains \"{0}\": True", search);
        }
        else if (aQueue.Contains(search) == false)
            Console.WriteLine("Queue contains \"{0}\": False", search);
        if (aQueue.Contains(search))
        {
            while(aQueue.Contains(search))
            {
                aQueue.Dequeue();
            }
        }
        return aQueue;
    }
}
