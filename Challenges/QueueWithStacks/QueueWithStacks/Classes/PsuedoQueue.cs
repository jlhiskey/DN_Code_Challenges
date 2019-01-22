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

        public PsuedoQueue(Node node)
        {
            Front = node;
            Back = node;
            
        }

        public int Enqueue(Node node)
        {

        }

        public int Dequeue(Node node)
        {

        }
    }
}
