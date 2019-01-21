using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    class Stack
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


    }
}
