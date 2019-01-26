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
        
        /// <summary>
        /// Returns a list of values from a binaryTree that are listed in PRE-ORDER
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
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
            PrintValues(preOrderValues);
            return preOrderValues;
        }

        /// <summary>
        /// Returns a list of values from a binaryTree that are listed IN-ORDER
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public List<int> InOrder(Node root)
        {
            List<int> inOrderValues = new List<int>();
            void InOrderHelper(Node helperRoot, List<int> listOfValues)
            {
                if (root == null)
                {
                    return;
                }
                InOrderHelper(root.Left, listOfValues);
                listOfValues.Add(root.Value);
                InOrderHelper(root.Right, listOfValues);
            }
            InOrderHelper(root, inOrderValues);
            PrintValues(inOrderValues);
            return inOrderValues;
        }

        /// <summary>
        /// Returns a list of values from a binaryTree that are listed in POST-ORDER
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public List<int> PostOrder(Node root)
        {
            List<int> postOrderValues = new List<int>();
            void InOrderHelper(Node helperRoot, List<int> listOfValues)
            {
                if (root == null)
                {
                    return;
                }
                InOrderHelper(root.Left, listOfValues);
                InOrderHelper(root.Right, listOfValues);
                listOfValues.Add(root.Value);
            }
            InOrderHelper(root, postOrderValues);
            PrintValues(postOrderValues);
            return postOrderValues;
        }

        /// <summary>
        /// Helper function that will print list values of each traversal in the console.
        /// </summary>
        /// <param name="listOfIntegers"></param>
        void PrintValues(List<int> listOfIntegers)
        {
            Console.WriteLine(listOfIntegers);
            foreach (int integer in listOfIntegers)
            {
                Console.Write($"{integer} ");
            }
        }
    }
}
