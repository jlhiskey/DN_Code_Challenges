using System;
using LinkedList.Classes;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LList test = new LList();

            test.InsertAtHead(1);
            test.InsertAtHead(2);
            test.InsertAtHead(3);
            test.PrintValues();
        }
    }
}
