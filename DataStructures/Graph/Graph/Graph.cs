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

        /// <summary>
        /// Conducts a breadth first traversal and returns a list of all visited Verticies.
        /// </summary>
        /// <param name="start"></param>
        /// <returns>List of visited Verticies</returns>
        public List<Vertex> BreadthFirstTraversal(Vertex start)
        {
            //Checks to make sure that start node exists in the graph.
            if (!_AdjacencyList.ContainsKey(start))
            {
                Console.WriteLine("Graph doesn't contain start vertex");
                return null;
            }

            // Holds all Verticies that will be visited.
            Queue<Vertex> queue = new Queue<Vertex>();

            // Holds all Verticies that have been visited.
            List<Vertex> inOrder = new List<Vertex>();

            //Keeps track of all nodes that have been visited with fast retreival
            Dictionary<Vertex, object> visitedVerticies = new Dictionary<Vertex, object>();

            //Adds start node to queue
            queue.Enqueue(start);

            //Adds start node to visited dictionary
            visitedVerticies.Add(start, null);

            //Runs while there are Verticies in the queue.
            while (queue.Count > 0)
            {
                //Targets the oldest Vertex in the queue.
                Vertex target = queue.Dequeue();

                //Adds Vertex to the visited list.
                inOrder.Add(target);

                //Empty LinkedList to hold output.
                LinkedList<Edge> neighbors;

                //Outputs a Vertex's neighbors
                _AdjacencyList.TryGetValue(target, out neighbors);

                //Checks to see if the vertex has any neighbors.
                if (neighbors.Count > 0)
                {
                    //Pulls the first edge out of the linked list.
                    Edge firstEdge = neighbors.First();

                    //Uses the first edge data to create a LinkedListNode with the first LL node as currentEdge
                    LinkedListNode<Edge> currentEdge = neighbors.Find(firstEdge);

                    //Runs until the end of the neighbors LL is reached.
                    while (currentEdge != null)
                    {
                        //Isolates the Vertex out of the LL node
                        Vertex neighbor = currentEdge.Value.Vertex;
                        //Checks to see if the neighbor has alread been visited.
                        if (!visitedVerticies.ContainsKey(neighbor))
                        {
                            //Adds vertex to visited dictionary
                            visitedVerticies.Add(neighbor, null);

                            //Adds vertex to queue.
                            queue.Enqueue(neighbor);
                        }
                        //Moves to next element of LL
                        currentEdge = currentEdge.Next;
                    }
                }              
            }

            // Checks if there is an island
            if(inOrder.Count < Size)
            {
                Console.WriteLine("You found an island.");
            }
            //Returns visited verticies
            return inOrder;
        }

    }
}
