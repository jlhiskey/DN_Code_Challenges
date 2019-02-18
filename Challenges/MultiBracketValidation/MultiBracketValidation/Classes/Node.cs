using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    /// <summary>
    /// Creates a node with a value. When creating a new node you must give it a value.
    /// </summary>
    public class Node
    {
        public char Value { get; set; }
        public Node Next { get; set; }

        public Node(char value)
        {
            Value = value;
        }

    }
    
}
