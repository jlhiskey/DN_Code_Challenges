using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzTree.Classes
{
    public class BinaryTree
    {
        public Node Root { get; set; }
        
        public BinaryTree()
        {
            Root = null;
        }
        
        /// <summary>
        /// Returns a list of values from a binaryTree that are listed in PRE-ORDER
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public List<string> PreOrder()
        {
            Node root = Root;
            List<string> preOrderValues = new List<string>();
            void PreOrderHelper(Node helperRoot, List<string> listOfValues)
            {
                if (helperRoot == null)
                {
                    return;
                }

                listOfValues.Add(helperRoot.Value);
                PreOrderHelper(helperRoot.Left, listOfValues);
                PreOrderHelper(helperRoot.Right, listOfValues);
            }
            PreOrderHelper(root, preOrderValues);
            PrintValues(preOrderValues, 1);
            return preOrderValues;
        }

        /// <summary>
        /// Returns a list of values from a binaryTree that are listed IN-ORDER
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public List<string> InOrder()
        {
            Node root = Root;
            List<string> inOrderValues = new List<string>();
            void InOrderHelper(Node helperRoot, List<string> listOfValues)
            {
                if (helperRoot == null)
                {
                    return;
                }
                InOrderHelper(helperRoot.Left, listOfValues);
                listOfValues.Add(helperRoot.Value);
                InOrderHelper(helperRoot.Right, listOfValues);
            }
            InOrderHelper(root, inOrderValues);
            PrintValues(inOrderValues, 2);
            return inOrderValues;
        }

        /// <summary>
        /// Returns a list of values from a binaryTree that are listed in POST-ORDER
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public List<string> PostOrder()
        {
            Node root = Root;
            List<string> postOrderValues = new List<string>();
            void InOrderHelper(Node helperRoot, List<string> listOfValues)
            {
                if (helperRoot == null)
                {
                    return;
                }
                InOrderHelper(helperRoot.Left, listOfValues);
                InOrderHelper(helperRoot.Right, listOfValues);
                listOfValues.Add(helperRoot.Value);
            }
            InOrderHelper(root, postOrderValues);
            PrintValues(postOrderValues, 3);
            return postOrderValues;
        }

        /// <summary>
        /// Helper function that will print list values of each traversal in the console.
        /// </summary>
        /// <param name="listOfValues"></param>
        void PrintValues(List<string> listOfValues, int searchType)
        {
            string response = "null";

            switch (searchType)
            {
                case 1:
                    response = "Pre-Order";
                    break;
                case 2:
                    response = "In-Order";
                    break;
                case 3:
                    response = "Post-Order";
                    break;
                default:
                    break;
            }

            Console.WriteLine($"{response} Traversal Results:");
            foreach (string value in listOfValues)
            {
                Console.Write($"{value} ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
