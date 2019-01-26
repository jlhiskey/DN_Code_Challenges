using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    class BinaryTree
    {
        Node Root { get; set; }
        
        public BinaryTree()
        {
            
        }
        
        public List<int> PreOrder(Node root)
        {
            List<int> preOrderValues = new List<int>();
            void PreOrderHelper(Node helperRoot, List<int> listOfValues)
            {
                if (root == null)
                {
                    return;
                }
                listOfValues.Add(root.Value);
                PreOrderHelper(root.Left, listOfValues);
                PreOrderHelper(root.Right, listOfValues);
            }
            PreOrderHelper(root, preOrderValues);
            return preOrderValues;
        }

        public int[] InOrder()
        {

        }

        public int[] PostOrder()
        {

        }
    }
}
