using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class LList
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
        public void Append(int value)
        {
            //Checks to see if linked list has any nodes
            if (Head == null)
            {
                //If not it will insert value at head
                InsertAtHead(value);
            }
            else
            {
                //Sets the target node as the head of the linked list
                Current = Head;

                //Creates new node with input value.
                Node current = new Node(value);

                //Iterates through the linked list until it finds the last node.
                while (Current.Next != null)
                {
                    Current = Current.Next;
                }

                //Adds new node to end of the list.
                Current.Next = current;
                Size = Size + 1;
            }             
        }

        public void InsertBefore(int targetValue, int value)
        {
            //Checks to see if linked list has any nodes
            if (Head == null)
            {
                //If not it will insert value at head
                InsertAtHead(value);
            }
            //Checks to see if head equals target value
            if (Head.Value == targetValue)
            {
                InsertAtHead(value);

            }
            else
            {
                //Sets the target node as the head of the linked list
                Current = Head;

                //Creates new node with input value.
                Node current = new Node(value);

                //Iterates through the linked list until it finds the target node.
                while (Current.Next.Value != targetValue && Current.Next.Next != null )
                {
                    
                    Current = Current.Next;
                }
                if ((Current.Next).Value == targetValue)
                {
                    //Saves the rest of the list before we add new node.
                    Node savedList = Current.Next;
                    //Adds new node to the list.
                    Current.Next = current;
                    //Adds the remainder of the list back onto the list.
                    Current.Next.Next = savedList;
                    Size = Size + 1;
                    //Clears memory
                    savedList = null;
                }
                else
                {
                    Console.WriteLine("Target Value Not Found");
                }
                
            }
        }

        // Includes Value
        public bool Includes(int value)
        {
            //Sets the target node as the head of the linked list
            Current = Head;

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
                Console.WriteLine($"Node {currentNodePosition + 1}) Value = {Current.Value}");
                
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
