using System;
using System.Collections.Generic;
class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search){

        System.Console.WriteLine($"Number of items: {aQueue.Count}");

        if (aQueue.Count <= 0)
            System.Console.WriteLine("Queue is empty");
        else
            System.Console.WriteLine($"First item: {aQueue.Peek()}");
        
        aQueue.Enqueue(newItem);

        System.Console.WriteLine($"Queue contains \"{search}\": {aQueue.Contains(search)}");
        if (aQueue.Contains(search))
        {
            while (aQueue.Contains(search)){
                aQueue.Dequeue();
            }
        }
        return aQueue;

    }
}