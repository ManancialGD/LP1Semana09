using System;
using System.Collections.Generic;

namespace IntCollections
{
    class Program
    {
        static private List<int> intList = new List<int>{1, 10, -30, 10, -5};
        static private Stack<int> intStack;
        static private Queue<int> intQueue;
        static private HashSet<int> intHashSet = new HashSet<int>{1, 10, -30, 10, -5};
        static void Main(string[] args)
        {
            // Add items to the Stack
            intStack.Push(1);
            intStack.Push(10);
            intStack.Push(-30);
            intStack.Push(10);
            intStack.Push(-5);

            // Add items to the Queue
            intQueue.Enqueue(1);
            intQueue.Enqueue(10);
            intQueue.Enqueue(-30);
            intQueue.Enqueue(10);
            intQueue.Enqueue(-5);
        }
    }
}
