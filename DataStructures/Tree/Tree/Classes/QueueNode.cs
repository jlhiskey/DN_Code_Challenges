using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class QueueNode
    {
        public int Value { get; set; }
        public QueueNode Next { get; set; }
        
        public QueueNode(int value)
        {
            Value = value;
        }

    }
}
