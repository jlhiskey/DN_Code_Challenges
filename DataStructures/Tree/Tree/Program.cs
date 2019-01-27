using System;
using Tree.Classes;

namespace Tree
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Binary Tree
            BinaryTree testTree = new BinaryTree();
            testTree.Root = new Node(1);
            testTree.Root.Left = new Node(2);
            testTree.Root.Right = new Node(3);
            testTree.Root.Left.Left = new Node(4);
            testTree.Root.Left.Right = new Node(5);

            Console.WriteLine("Binary Tree");
            testTree.PreOrder();
            testTree.InOrder();
            testTree.PostOrder();

            // Binary Search Tree
            BinarySearchTree testBST = new BinarySearchTree();
            testBST.Add(4);
            testBST.Add(2);
            testBST.Add(6);
            testBST.Add(1);
            testBST.Add(3);
            testBST.Add(5);
            testBST.Add(7);

            Console.WriteLine("Binary Search Tree");
            testBST.InOrder();


            Console.ReadLine();
        }
    }
}
