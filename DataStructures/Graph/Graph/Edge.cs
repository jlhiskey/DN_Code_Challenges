using System;
using System.Collections.Generic;
using System.Text;

namespace Graph
{
    /// <summary>
    /// Connection between Verticies
    /// </summary>
    public class Edge
    {
        /// <summary>
        /// Start Vertex's neighbor.
        /// </summary>
        public Vertex Vertex { get; set; }

        /// <summary>
        /// Cost of getting from Start Vertex to neighbor.
        /// </summary>
        public int Weight { get; set; }

        /// <summary>
        /// Creates a new edge with Vertex neighbor and int weight as input.
        /// </summary>
        /// <param name="vertex"></param>
        /// <param name="weight"></param>
        public Edge(Vertex neighbor, int weight)
        {
            Vertex = neighbor;

            Weight = weight;

        }
    }
}
