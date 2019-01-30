using System;
using System.Collections.Generic;
using System.Text;
using Tree.Classes;

namespace StacksAndQueues.Classes
{
    /// <summary>
    /// Creates a node with a value. When creating a new node you must give it a value.
    /// </summary>
    public class QNode
    {
        public Node Value { get; set; }
        public QNode Next { get; set; }

        public QNode(Node value)
        {
            Value = value;
        }

    }
    
}
