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
        }

        public long Hasher(string key)
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

            return caluculatedValue;
        }
    }
}
