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
            long caluculatedValue = 0;
            for (int i = 0; i < key.Length; i++)
            {
                long charValue = (int)key[i];
                caluculatedValue = caluculatedValue + charValue; 
                        
            }
            caluculatedValue = caluculatedValue * 199;
            caluculatedValue = caluculatedValue / 1024;
            caluculatedValue = caluculatedValue % Container;

            int hashKey = Convert.ToInt32(caluculatedValue);
            Console.WriteLine($"Key= {key} Hash Key= {hashKey}");
            Console.WriteLine();
            return hashKey;
        }

        public void Add(string key, object value)
        {
            Console.WriteLine("Adding Data");
            Console.WriteLine();

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
                while(currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = incoming;
            }
            Size = Size + 1;
            Console.WriteLine($"Added {key} {value} to Index {index}");
            Console.WriteLine();
        }

        public object Get(string key)
        {
            int index = Hasher(key);
            
            if (Storage[index].Key == key)
            {
                Console.WriteLine($"Your value is {Storage[index].Value}.");
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
                if (currentNode.Key == key)
                {
                    Console.WriteLine($"Your value is {currentNode.Value}.");
                    return currentNode.Value;
                }

                else
                {
                    Console.WriteLine("Value not found");
                    return null;
                }            
            }
           
        }

        public bool Contains(string key)
        {
            int index = Hasher(key);

            if (Storage[index] == null)
            {
                Console.WriteLine("Key not found");
                return false;
            }
            if (Storage[index].Key == key)
            {
                Console.WriteLine("Key found");
                return true;
            }
            else
            {
                HashNode currentNode = Storage[index];

                while (currentNode.Key != key && currentNode.Next != null)
                {
                    Console.WriteLine("Accessing Collision Storage");
                    currentNode = currentNode.Next;
                }
                if(currentNode.Key == key)
                {
                    Console.WriteLine("Key found");
                    return true;
                }
                Console.WriteLine("Key not found");
                return false;    
            }
        }

        public void Remove(string key)
        {
            int index = Hasher(key);

            if (Storage[index].Key == key && Storage[index].Next == null)
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
    }
}
