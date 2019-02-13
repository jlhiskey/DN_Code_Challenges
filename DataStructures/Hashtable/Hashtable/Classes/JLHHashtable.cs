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

            return hashKey;
        }

        public void Add(string key, object value)
        {
            HashNode incoming = new HashNode(key, value);

            int index = Hasher(key);

            if (Storage[index] == null)
            {
                Storage[index] = incoming;
            }
            else
            {
                HashNode currentNode = Storage[index];
                while(currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = incoming;
            }
        }

        public object Get(string key)
        {
            int index = Hasher(key);
            HashNode outgoing = new HashNode("null", "null");
            string targetKey = Storage[index].Key;
            if (targetKey == key)
            {
                outgoing = Storage[index];
            }
            else
            {
                HashNode currentNode = Storage[index];
                targetKey = currentNode.Key;
                while (targetKey != key)
                {
                    currentNode = currentNode.Next;
                    targetKey = currentNode.Key;
                }
                outgoing = currentNode;
            }
            return outgoing.Value;
        }
    }
}
