using Hashtable.Classes;
using System;
using System.Collections.Generic;

namespace LeftJoin
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// Takes in two hashtables and outputs a list of all left hashtable values and any right table values that have a matching key.
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns>List with join data. LeftKey, LeftValue, RightValue</returns>
        public static List<string> LeftJoin(HashTable left, HashTable right)
        {
            //List to hold join data.
            List<string> joinTable = new List<string>();

            //Stepping through all hashnode is left hash table
            for (int i = 0; i < left.Storage.Length; i++)
            {
                //If the bucket has a hashnode in it
                if (left.Storage[i] != null)
                {
                    //Take the first hashnode out of the bucket.
                    HashNode currentNode = left.Storage[i];
                    
                    //Runs until collision storage is null
                    while (currentNode != null)
                    {
                        //Will hold the data collected from hashnode
                        string concat = null;
                        //Adds left hashnode key and value
                        concat = concat + $"{currentNode.Key}, {currentNode.Value.ToString()}, ";
                        //Checks to see if right hashtable contains matching key
                        if (right.Contains(currentNode.Key))
                        {
                            // Adds right hashnodes value to concat
                            concat = concat + right.Get(currentNode.Key).ToString();
                        }
                        else
                        {
                            //Adds NULL if right hashtable doesnt have matching key
                            concat = concat + "NULL";
                        }
                        //Adds saved key value data to list.
                        joinTable.Add(concat);
                        //Moves to next node in collision storage.
                        currentNode = currentNode.Next;
                    }
                }
            }
            //Returns joinTable
            return joinTable;
        }
    }
}
