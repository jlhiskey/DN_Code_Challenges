using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class BinarySearchTree : BinaryTree
    {
        int Size { get; set; } = 0;

        public void Add(int value)
        {
            
            Node newNode = new Node(value);

            if (Root == null)
            {
                Root = newNode;
                Size = Size + 1;
            }
            else
            {
                Node root = Root;
                void HelperAdd(Node helperRoot, int helperValue)
                {
                    if (value < helperRoot.Value)
                    {
                        if (helperRoot.Left == null)
                        {
                            helperRoot.Left = newNode;
                            Size = Size + 1;
                        }
                        else
                        HelperAdd(helperRoot.Left, helperValue);
                    }
                    else
                    {
                        if (helperRoot.Right == null)
                        {
                            helperRoot.Right = newNode;
                            Size = Size + 1;
                        }
                        else
                            HelperAdd(helperRoot.Right, helperValue);
                    }
                }
                HelperAdd(root, value);
            }

                    
        }

        public bool Contains(int value)
        {
            Node root = Root;
            bool targetFound = false;
            void HelperContains(Node helperRoot, int helperValue)
            {
                if (!targetFound)
                {
                    if (helperRoot == null)
                    {
                    return;
                    }
                    if (helperRoot.Value == helperValue)
                    {
                    targetFound = true;
                    return;
                    }
                    if (helperValue < helperRoot.Value)
                    {
                        HelperContains(helperRoot.Left, helperValue);
                    }
                    else
                    {
                        HelperContains(helperRoot.Right, helperValue);
                    }
                }
                return;
            }
            HelperContains(root, value);
            Console.WriteLine($"Does this BST contain the number: {value} ? {targetFound}");
            return targetFound;
        }
        
    }
}
