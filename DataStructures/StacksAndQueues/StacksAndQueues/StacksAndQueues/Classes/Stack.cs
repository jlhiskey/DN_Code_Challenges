using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Stack
    {
        public Node Top { get; set; }
        public int Size { get; set; } = 0;

        /// <summary>
        /// Creates a new stack with a node.
        /// </summary>
        /// <param name="node"></param>
        public Stack(Node node)
        {
            Top = node;
            Size = Size + 1;
        }

        /// <summary>
        /// Creates a new empty stack.
        /// </summary>
        public Stack()
        {

        }

        /// <summary>
        /// Adds a new node to the stack.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Returns Top of stack.</returns>
        public Node Push(int value)
        {
            Node node = new Node(value);
            node.Next = Top;
            Top = node;
            Size = Size + 1;
            return Top;
        }

        /// <summary>
        /// Checks for size of stack and removes Top value of stack if Size > 0.
        /// </summary>
        /// <returns>Returns popped node.</returns>
        public Node Pop()
        {
            if( Size == 0)
            {
                return null;
            }
            else
            {
                Node helper = Top;
                Top = Top.Next;
                helper.Next = null;
                Size = Size - 1;
                return helper;
            }
        }

        /// <summary>
        /// Returns value that is Top of the stack.
        /// </summary>
        /// <returns></returns>
        public Node Peek()
        {
            return Top;
        }

        /// <summary>
        /// Returns int value representing total nodes in stack.
        /// </summary>
        /// <returns>int</returns>
        public int GetSize()
        {
            return Size;
        }
    }
}
