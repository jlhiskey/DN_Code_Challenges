using System;
using LinkedList.Classes;

namespace ll_merge
{
    public class Program
    {
        static void Main(string[] args)
        {
            LList testList = new LList();
            
            testList.InsertAtHead(5);
            testList.InsertAtHead(3);
            testList.InsertAtHead(1);

            LList testList2 = new LList();
            testList2.InsertAtHead(7);
            testList2.InsertAtHead(6);
            testList2.InsertAtHead(4);
            testList2.InsertAtHead(2);

            LList Result = Merge(testList, testList2);
        }

        /// <summary>
        /// Takes in two linked lists and returns a zipped linked list with LList one acting as the Head of the zipped list.
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        /// <returns></returns>
        public static LList Merge(LList one, LList two )
        {
            //Edge Cases
            if(one.Head == null && two.Head != null)
            {
                return two;
            }

            if (two.Head == null && one.Head != null)
            {
                return one;
            }

            if (one.Head == null && two.Head == null)
            {
                return null;
            }

            Node currentOne = one.Head;
            Node currentTwo = two.Head;
            Node helperOne;
            Node helperTwo;
            one.Size = one.Size + two.Size;

            //Handles Even Lists
            while(currentOne.Next != null && currentTwo.Next != null)
            {
                helperOne = currentOne.Next;
                currentOne.Next = currentTwo;
                currentOne = helperOne;
                helperTwo = currentTwo.Next;
                currentTwo.Next = currentOne;
                currentTwo = helperTwo;
            }

            //Handles Uneven Lists
            if(currentTwo.Next == null)
            {
                helperOne = currentOne.Next;
                currentOne.Next = currentTwo;
                currentTwo.Next = helperOne;
            }
            else
            {
                currentOne.Next = currentTwo;
            }
            return one;
        }
    }
}
