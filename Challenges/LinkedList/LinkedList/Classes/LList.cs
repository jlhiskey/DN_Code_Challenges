using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    class LList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }
        public int Size { get; set; }

        // Insert at Head
        public void InsertAtHead(int value)
        {   
            // Creates a new node with input value
            Node current = new Node(value);

            // Stores the node that used to be the head of the linked list as the current nodes next value.
            current.Next = Head;

            // Sets the current node as the head of the list.
            Head = current;
            Size = Size + 1;
        }

        // Includes Value
        public bool Includes(int value)
        {
            //Sets the target node as the head of the linked list
            Current = Head;

            //Checks first node value to see if it equals input value.
            if (Current.Value == value)
            {
                return true;
            }

            //Runs through the list until the current node doesnt have a next value.
            while (Current != null)
            {
                //Checks to see if the current nodes value is equal to the input value
                if(Current.Value == value)
                {
                    return true;
                }
                
                // If value isn't found then the current node moves to the next node in the list.
                Current = Current.Next;
            }
            return false;
        }

        // Print Values
        public int[] PrintValues()
        {
            int[] printArray = new int[Size];
            //Sets the target node as the head of the linked list
            Current = Head;
            //Keeps track of node position.
            int currentNodePosition = 0;
            //Runs through the list until the current node doesnt have a next value.
            while (Current != null)
            {
                //Populates print array with value of node
                printArray[currentNodePosition] = Current.Value;
                
                //Changes current node position value
                currentNodePosition = currentNodePosition + 1;

                //Moves current node to current node.next
                Current = Current.Next;
            }
            //Returns printArray
            return printArray;
        }

    }
}
