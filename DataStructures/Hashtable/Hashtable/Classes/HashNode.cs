using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtable.Classes
{
    /// <summary>
    /// Provides a node for the Hashtable Class to use to store data. Key is a string and Value is an object so that data can be generic within node.
    /// </summary>
    public class HashNode
    {
        /// <summary>
        /// Key of the HashNode
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// Payload of the HashNode
        /// </summary>
        public object Value { get; set; }
        /// <summary>
        /// Collision Data Structure
        /// </summary>
        public HashNode Next { get; set; }

        /// <summary>
        /// HashNode constructor that accepts a string as a key and an object as a value.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public HashNode(string key, object value)
        {
            Key = key;
            Value = value;
            Next = null;
        }
    }
}
 