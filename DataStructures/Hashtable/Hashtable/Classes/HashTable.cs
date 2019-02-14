using System;
using System.Collections.Generic;
using System.Text;
using Hashtable.Classes;

namespace Hashtable.Classes
{
    /// <summary>
    /// Homemade Hashtable that contains .Hasher, .Add, .Get, .Contains, .Remove capablities. Hashtable buckets must be specified and will not resize. Collision handling is enabled to allow for unlimited additions.
    /// </summary>
    public class HashTable
    {
        /// <summary>
        /// Bucket Population
        /// </summary>
        public int TotalBuckets { get; set; }
        /// <summary>
        /// Data Population
        /// </summary>
        public int Size { get; set; }
        /// <summary>
        /// Data Container
        /// </summary>
        public HashNode[] Storage { get; set; }

        /// <summary>
        /// HashTable Constructor function that requires an integer input designating how many buckets HashTable will contain.
        /// </summary>
        /// <param name="totalBuckets"></param>
        public HashTable(int totalBuckets)
        {
            TotalBuckets = totalBuckets;
            HashNode[] temp = new HashNode[TotalBuckets];
            Storage = temp;
        }

        /// <summary>
        /// Receives a string input and returns an integer value indicating which index key has mapped to. Uses ASCII sum of string characters * 699 % TotalBuckets to acheive hash.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public int Hasher(string key)
        {
            Console.WriteLine();
            Console.WriteLine("Hashing Key---------------------------");
            Console.WriteLine();
            long caluculatedValue = 0;
            for (int i = 0; i < key.Length; i++)
            {
                long charValue = (int)key[i];
                caluculatedValue = caluculatedValue + charValue; 
                        
            }
            caluculatedValue = caluculatedValue * 699;
            caluculatedValue = caluculatedValue % TotalBuckets;

            int hashKey = Convert.ToInt32(caluculatedValue);
            Console.WriteLine($"Key= {key} Hash Key= {hashKey}");
            Console.WriteLine();
            Console.WriteLine("Hashing Complete---------------------------");
            Console.WriteLine();
            return hashKey;
        }

        /// <summary>
        /// Receives a string key and a object value and adds them to HashTable if unique. Adds to collision data structure if collision is found.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Add(string key, object value)
        {
            Console.WriteLine();
            Console.WriteLine("Adding Data---------------------------");
            Console.WriteLine();

            if (Contains(key))
            {
                Console.WriteLine("Identical Key found");
                Console.WriteLine();
            }
            else
            {
                HashNode incoming = new HashNode(key, value);

                int index = Hasher(key);

                if (Storage[index] == null)
                {
                    Storage[index] = incoming;
                }
                else
                {
                    Console.WriteLine("Collision Detected");
                    HashNode currentNode = Storage[index];
                    while (currentNode.Next != null)
                    {
                        currentNode = currentNode.Next;
                    }
                    currentNode.Next = incoming;
                }
                Size = Size + 1;
                Console.WriteLine($"Added {key} {value} to Index {index}");
                Console.WriteLine();
            }
            
        }

        /// <summary>
        /// Checks to see if HashTable contains string key value and returns object value if found. Will enter collision data structure to find value if collision is encountered.
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Object value</returns>
        public object Get(string key)
        {
            Console.WriteLine();
            Console.WriteLine("Retreiving Data---------------------------");
            Console.WriteLine();
            
            if (!Contains(key))
            {
                Console.WriteLine("Value not found");
                return null;
                
            }
            else
            {
                int index = Hasher(key);
                if (Storage[index].Key == key)
                {
                    Console.WriteLine($"Your value is {Storage[index].Value}.");
                    Console.WriteLine();
                    return Storage[index].Value;
                }
                else
                {
                    HashNode currentNode = Storage[index];

                    while (currentNode.Key != key)
                    {
                        Console.WriteLine("Accessing Collision Storage");
                        currentNode = currentNode.Next;
                    }
                    Console.WriteLine($"Your value is {currentNode.Value}.");
                    Console.WriteLine();
                    return currentNode.Value;
                }
            }
            
            
        }

        /// <summary>
        /// Checks HashTable to see if a HashNode within the HashTable including collision data structure contains input string key returns a boolean 
        /// </summary>
        /// <param name="key"></param>
        /// <returns>bool keyFound</returns>
        public bool Contains(string key)
        {
            Console.WriteLine();
            Console.WriteLine("Running Contain---------------------------");
            int index = Hasher(key);

            if (Storage[index] == null)
            {
                Console.WriteLine("Key not found");
                Console.WriteLine();
                Console.WriteLine("Contain Complete---------------------------");
                Console.WriteLine();
                return false;
            }
            if (Storage[index].Key == key)
            {
                Console.WriteLine("Key found");
                Console.WriteLine();
                Console.WriteLine("Contain Complete---------------------------");
                Console.WriteLine();
                return true;
            }
            else
            {
                HashNode currentNode = Storage[index];

                while (currentNode.Key != key && currentNode.Next != null)
                {
                    Console.WriteLine("Accessing Collision Storage");
                    Console.WriteLine();

                    currentNode = currentNode.Next;
                }
                if(currentNode.Key == key)
                {
                    Console.WriteLine("Key found");
                    Console.WriteLine();
                    Console.WriteLine("Contain Complete---------------------------");
                    return true;
                }
                Console.WriteLine("Key not found");
                Console.WriteLine();
                Console.WriteLine("Contain Complete---------------------------");
                return false;    
            }
        }

        /// <summary>
        /// Checks to see if HashTable including collision data structure contains input string key and removes HashNode that matches key. 
        /// </summary>
        /// <param name="key"></param>
        public void Remove(string key)
        {
            Console.WriteLine("Removing Data---------------------------");
            Console.WriteLine();
            
            if (!Contains(key))
            {
                Console.WriteLine($"Hashtable does not contain {key}.");
                Console.WriteLine();
            }
            else
            {
                int index = Hasher(key);
                if ((Storage[index].Key == key && Storage[index].Next == null))
                {
                    Console.WriteLine($"Removing {Storage[index].Key} {Storage[index].Value} from hashtable.");
                    Storage[index] = null;
                    Size = Size - 1;
                }
                else
                {
                    if (Storage[index].Key == key && Storage[index].Next != null)
                    {
                        Console.WriteLine($"Removing {Storage[index].Key} {Storage[index].Value} from hashtable and amending collision storage.");
                        Storage[index] = Storage[index].Next;
                        Size = Size - 1;
                    }
                    else
                    {
                        HashNode currentNode = Storage[index];


                        while (currentNode.Next.Key != key && currentNode.Next != null)
                        {
                            Console.WriteLine("Accessing Collision Storage");
                            currentNode = currentNode.Next;
                        }
                        if (currentNode.Next.Key == key && currentNode.Next.Next != null)
                        {
                            Console.WriteLine($"Removing {currentNode.Next.Key} {currentNode.Next.Value} from hashtable and amending collision storage.");
                            currentNode.Next = currentNode.Next.Next;
                            Size = Size - 1;
                        }
                        else
                        {
                            Console.WriteLine($"Removing {currentNode.Next.Key} {currentNode.Next.Value} from hashtable and amending collision storage.");
                            currentNode.Next = null;
                            Size = Size - 1;
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
