using System;
using System.Collections.Generic;
using System.Text;
using Hashtable.Classes;

namespace Hashtable.Classes
{
    public class JLHHashtable
    {
        public int Container { get; set; }
        public int Size { get; set; }
        public HashNode[] Storage { get; set; }

        public JLHHashtable(int container)
        {
            Container = container;
            HashNode[] temp = new HashNode[Container];
            Storage = temp;
        }

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
            caluculatedValue = caluculatedValue % Container;

            int hashKey = Convert.ToInt32(caluculatedValue);
            Console.WriteLine($"Key= {key} Hash Key= {hashKey}");
            Console.WriteLine();
            Console.WriteLine("Hashing Complete---------------------------");
            Console.WriteLine();
            return hashKey;
        }

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
                }
                else
                {
                    if (Storage[index].Key == key && Storage[index].Next != null)
                    {
                        Console.WriteLine($"Removing {Storage[index].Key} {Storage[index].Value} from hashtable and amending collision storage.");
                        Storage[index] = Storage[index].Next;
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
                        }
                        else
                        {
                            Console.WriteLine($"Removing {currentNode.Next.Key} {currentNode.Next.Value} from hashtable and amending collision storage.");
                            currentNode.Next = null;
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
