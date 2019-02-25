using System;
using System.Collections.Generic;
using System.Linq;

namespace Graph
{
    public class Graph
    {

        /// <summary>
        /// Number of Vertices in Graph
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// Dictionary that is actually holding the verticies and edges
        /// </summary>
        public Dictionary<Vertex, LinkedList<Edge>> _AdjacencyList { get; set; }

        /// <summary>
        /// Graph constructor that builds AdjacenyList and sets Size of graph to 0.
        /// </summary>
        public Graph()
        {
            Dictionary<Vertex, LinkedList<Edge>> adjacencyList = new Dictionary<Vertex, LinkedList<Edge>>();
            _AdjacencyList = adjacencyList;
            Size = 0;
        }

        /// <summary>
        /// Accepts a Vertex as an input creates a new empty LinkedList neighbors that will keep track of the new Vertex's neighbors and adds new Vertex and LinkedList to graph.
        /// </summary>
        /// <param name="vertex"></param>
        public Vertex AddVertex(Vertex vertex)
        {

            LinkedList<Edge> neighbors = new LinkedList<Edge>();
            _AdjacencyList.Add(vertex, neighbors);
            Size = Size + 1;
            return vertex;
        }

        /// <summary>
        /// Accepts Vertex startVertex, Vertex endVertex and optionally an int weight. Checks to see if graph contains both vertices then adds connection between vertices in Vertex startVertex Linked List neighbors.
        /// </summary>
        /// <param name="startVertex"></param>
        /// <param name="endVertex"></param>
        /// <param name="weight"></param>
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

        /// <summary>
        /// Checks to see if there are Verticies in the graph. If yes will return a List<Vertex>AllVertices</Vertex> else it will return null.
        /// </summary>
        /// <returns>If graph has Verticies then it returns a List of all Vertex in graph else it returns null.</returns>
        public List<Vertex> GetVerticies()
        {
            if(Size > 0)
            {
                return _AdjacencyList.Keys.ToList();
            }
            return null;
        }

        /// <summary>
        /// Accepts a Vertex as input and checks to see if Vertex exists in graph. If it does then a List of Edges is returned. Else an exception is thrown.
        /// </summary>
        /// <param name="vertex"></param>
        /// <returns>If the Vertex exists in graph then a List of that Vertex's edges in returned else an exeption is thrown.</returns>
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

        /// <summary>
        /// Accesses the Graphs Size property and returns int value indicating how many Verticies exist in Graph.
        /// </summary>
        /// <returns>int value indicating how many Verticies exist in Graph.</returns>
        public int GetSize()
        {
            return Size;
        }

        public List<Vertex> BreadthFirst(Vertex start)
        {
            if (!_AdjacencyList.ContainsKey(start))
            {
                Console.WriteLine("Graph doesn't contain start vertex");
                return null;
            }

            Queue<Vertex> queue = new Queue<Vertex>();

            List<Vertex> inOrder = new List<Vertex>();

            Dictionary<Vertex, object> visitedVertices = new Dictionary<Vertex, object>();

            queue.Enqueue(start);

            while(queue.Count > 0)
            {
                Vertex target = queue.Dequeue();

                visitedVertices.Add(target, null);
                inOrder.Add(target);

                LinkedList<Edge> neighbors;

                _AdjacencyList.TryGetValue(target, out neighbors);

                Edge firstEdge = neighbors.First();
                LinkedListNode<Edge> currentEdge = neighbors.Find(firstEdge);

                while (currentEdge != null)
                {
                    Vertex neighbor = currentEdge.Value.Vertex;
                    if(!visitedVertices.ContainsKey(neighbor))
                    {
                        queue.Enqueue(neighbor);
                    }
                    currentEdge = currentEdge.Next;
                }
            }
            return inOrder;

        }

    }
}
