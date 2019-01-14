using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    class LList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }

        // Insert at Head
        public void InsertAtHead(int value)
        {
            Node current = new Node(value);
            current.Next = Head;
            Head = current;
        }


        // Includes Value

        // Print Value

    }
}
