using System;
using System.Collections.Generic;
using System.Text;

namespace Graph
{
    /// <summary>
    /// Payload of Graph
    /// </summary>
    public class Vertex
    {
        /// <summary>
        /// Generic payload of Vertex
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// Accepts a generic input value and sets Value of new Vertex to that value.
        /// </summary>
        /// <param name="value"></param>
        public Vertex(object value)
        {
            Value = value;
        }
    }
}
