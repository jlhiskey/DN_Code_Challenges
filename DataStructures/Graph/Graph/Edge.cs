using System;
using System.Collections.Generic;
using System.Text;

namespace Graph
{
    public class Edge
    {
        //Vertex
        public Vertex Vertex { get; set; }

        //Weight
        public int Weight { get; set; }

        //Constructor
        public Edge(Vertex vertex, int weight)
        {
            Vertex = vertex;

            Weight = weight;

        }
    }
}
