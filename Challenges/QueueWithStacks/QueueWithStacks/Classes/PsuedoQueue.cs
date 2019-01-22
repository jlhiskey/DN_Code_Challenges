using StacksAndQueues.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace QueueWithStacks.Classes
{
    class PsuedoQueue
    {
        Stack stackOne = new Stack();
        Stack stackTwo = new Stack();

        public Node Front { get; set; }
        public Node Back { get; set; }

        public PsuedoQueue(int value)
        {
           Node node = stackOne.Push(value);
            Front = node;
            Back = node;
        }

        public int Enqueue(int value)
        {

        }

        public int Dequeue(int value)
        {

        }
    }
}
