using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtable.Classes
{
    public class HashNode
    {
        public string Key { get; set; }
        public object Value { get; set; }
        public HashNode Next { get; set; }

        public HashNode(string key, object value)
        {
            Key = key;
            Value = value;
            Next = null;
        }
    }
}
 