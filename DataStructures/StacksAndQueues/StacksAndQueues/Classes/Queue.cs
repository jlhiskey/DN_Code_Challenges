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
        /// Creates an empty queue.
        /// </summary>
        public Queue()
        {

        }

        /// <summary>
        /// Adds new node to the back of the queue and then once added returns value of node.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Node</returns>
        public Node Enqueue(int value)
        {
            Node node = new Node(value);
            if (Size == 0)
            {
                Front = node;
                Back = node;
            }
            else
            {
                Back.Next = node;
                Back = node;
            }
            Size = Size + 1;
            return Back;
        }

        /// <summary>
        /// Returns oldest node in the queue.
        /// </summary>
        /// <returns>Node</returns>
        public Node Dequeue()
        {
            if (Size == 0)
            {
                Console.WriteLine("Queue empty");
                return null;
            }
            else
            {
                Node helper = Front;
                Front = Front.Next;
                helper.Next = null;
                Size = Size - 1;
                return helper;
            }
        }

        /// <summary>
        /// Returns node that is at the front of the queue.
        /// </summary>
        /// <returns>Node</returns>
        public Node Peek()
        {
            return Front;
        }

        /// <summary>
        /// Returns number of nodes in queue.
        /// </summary>
        /// <returns></returns>
        public int GetSize()
        {
            return Size;
        }
    }
}
