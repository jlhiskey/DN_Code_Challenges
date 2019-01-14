using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    /// <summary>
    /// When instantiated creates a node object with a integer value and references to previous and next node.
    /// </summary>
    class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int value)
        {
            Value = value;
        }
    }
}
