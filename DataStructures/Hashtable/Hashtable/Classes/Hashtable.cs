using System;
using System.Collections.Generic;
using System.Text;
using Hashtable.Classes;

namespace Hashtable.Classes
{
    class Hashtable
    {
        public int Container { get; set; }
        public int Size { get; set; }
        public HashNode[] Storage { get; set; }

        Hashtable(int container)
        {
            Container = container;
            HashNode[] temp = new HashNode[Container];
        }

        public int Hasher(string key)
        {
            int hashKey = 0;
            for (int i = 0; i < key.Length; i++)
            {
                hashKey = hashKey + (int)key[i];
            }

            return hashKey;
        }
    }
}
