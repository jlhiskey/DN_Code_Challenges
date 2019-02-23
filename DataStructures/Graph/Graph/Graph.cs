using System;
using System.Collections.Generic;
using System.Linq;

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
            Size = Size + 1;
        }

        //Add Edge
        public void AddEdge(Vertex startVertex, Vertex endVertex, int weight = 0)
        {
            if(!_AdjacencyList.ContainsKey(startVertex) || !_AdjacencyList.ContainsKey(endVertex))
            {
                throw new Exception();
            }

            Edge edge = new Edge(endVertex, weight);
            LinkedList<Edge> neighbors;

            _AdjacencyList.TryGetValue(startVertex, out neighbors);    
            
            neighbors.AddFirst(edge);

            _AdjacencyList[startVertex] = neighbors;
        }

        //GetVerticies
        public List<Vertex> GetVertices()
        {
            if(Size > 0)
            {
                return _AdjacencyList.Keys.ToList();
            }
            return null;
        }

        //GetNeighbors
        public List<Edge> GetNeighbors(Vertex vertex)
        {
            if (!_AdjacencyList.ContainsKey(vertex))
            {
                throw new Exception();
            }

            LinkedList<Edge> neighbors;
            _AdjacencyList.TryGetValue(vertex, out neighbors);
            return neighbors.ToList();      
        }

        //GetSize
        public int GetSize()
        {
            return Size;
        }


    }
}
