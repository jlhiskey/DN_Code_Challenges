using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class QueueNode
    {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public QueueNode(int value)
        {
            Value = value;
        }

    }
}
