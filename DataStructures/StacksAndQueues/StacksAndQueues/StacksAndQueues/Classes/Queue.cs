using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Queue
    {
        public Node Front { get; set; }
        public Node Back { get; set; }
        public int Size { get; set; } = 0;

        /// <summary>
        /// Creates a new queue with an initial node.
        /// </summary>
        /// <param name="node"></param>
        public Queue(Node node)
        {
            Front = node;
            Back = node;
            Size = Size + 1;
        }

        /// <summary>
        /// Adds new node to the back of the queue and then once added returns value of node.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Node Enqueue(int value)
        {
            Node node = new Node(value);
            Back.Next = node;
            Back = node;
            Size = Size + 1;
            return Back;
        }
    }
}
