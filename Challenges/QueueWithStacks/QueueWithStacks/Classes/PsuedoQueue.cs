using StacksAndQueues.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace QueueWithStacks.Classes
{
    public class PsuedoQueue
    {
        Stack stackOne = new Stack();
        Stack stackTwo = new Stack();
        
        public PsuedoQueue(int value)
        {
           Node node = stackOne.Push(value);
           
        }

        /// <summary>
        /// Adds value onto PsuedoQueue
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int Enqueue(int value)
        {
            Node node = stackOne.Push(value);
         
            return node.Value;
        }

        /// <summary>
        /// Removes value from PsuedoQueue
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int Dequeue()
        {
            Node current;
            while (stackOne.Peek() != null)
            {
                stackTwo.Push(stackOne.Pop().Value);
            }
            current = stackTwo.Pop();
            while (stackTwo.Peek() != null)
            {
                stackOne.Push(stackTwo.Pop().Value);
            }
            return current.Value;
        }
    }
}
