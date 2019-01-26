using System;
using Tree.Classes;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree testTree = new BinaryTree();
            testTree.Root = new Node(1);
            testTree.Root.Left = new Node(2);
            testTree.Root.Right = new Node(3);
            testTree.Root.Left.Left = new Node(4);
            testTree.Root.Left.Right = new Node(5);
            testTree.Root.Right.Left = new Node(6);
            testTree.Root.Right.Right = new Node(7);

            testTree.PreOrder();
            testTree.InOrder();
            testTree.PostOrder();
            Console.ReadLine();
        }
    }
}
