using System;
using LinkedList.Classes;

namespace LLKthFromEnd
{
    public class Program
    {
        static void Main(string[] args)
        {
            LList test = new LList();
            test.InsertAtHead(3);
            test.InsertAtHead(2);
            test.InsertAtHead(1);
            int answer = KthFromEnd(test, 8);

        }

        /// <summary>
        /// Using a link list class that I created that has a Size property ;) Takes in an existing linked list and an integer and returns the integer value of the node that is kth from the end of the linked list. Returns -404 if k is out of bounds of the linked list.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int KthFromEnd(LList name, int k)
        {    
            //If the size of the linked list is smaller than k then it will return -404.
            if(name.Size < k)
            {
                return -404;
            }
            else
            {
                // Sets head as the current node.
                name.Current = name.Head;
                // Sets current node to desired node
                for (int i = 0; i < name.Size - k - 1; i++)
                {
                    name.Current = name.Current.Next;
                }
                // Returns current nodes value.
                return name.Current.Value;
            }
        }
    }
}
