using System;
using System.Collections.Generic;

namespace Graph
{
    public class Graph
    {

        //Size
        public int Size { get; set; }

        //AdjacencyList
        public Dictionary<Vertex, LinkedList<Edge>> _AdjacencyList { get; set; }

        //Constructor
        public Graph()
        {
            Dictionary<Vertex, LinkedList<Edge>> adjacencyList = new Dictionary<Vertex, LinkedList<Edge>>();
            _AdjacencyList = adjacencyList;
            Size = 0;
        }

        //Add Vertex
        public void AddVertex(Vertex vertex)
        {
            LinkedList<Edge> neighbors = new LinkedList<Edge>();
            _AdjacencyList.Add(vertex, neighbors);
        }

        //Add Edge

        //GetVerticies

        //GetNeighbors

        //GetSize


    }
}
