using Graph;
using System;
using System.Collections.Generic;

namespace DepthFirst
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static List<Vertex> DepthFirst(Graph.Graph graph)
        {
            List<Vertex> preOrder = new List<Vertex>();
            List<Vertex> allVerticies = graph.GetVerticies();
            HashSet<Vertex> visitedVerticies = new HashSet<Vertex>();
            Stack<Vertex> stack = new Stack<Vertex>();
            Vertex start = null;

            Vertex FindLowestVertex(List<Vertex> listOfVerticies)
            {
                Vertex lowestVertex = null;
                int lowestValue = 0;

                foreach(Vertex vertex in listOfVerticies)
                {
                    if(!visitedVerticies.Contains(vertex))
                    {
                        if (lowestVertex == null)
                        {
                            lowestVertex = vertex;
                            lowestValue = int.Parse(vertex.Value.ToString());
                        }
                        if(int.Parse(vertex.Value.ToString()) < lowestValue)
                        {
                            lowestVertex = vertex;
                            lowestValue = int.Parse(vertex.Value.ToString());
                        }
                    }
                    return null;
                    
                }
                return lowestVertex;
            }

            start = FindLowestVertex(allVerticies);

            stack.Push(start);

            visitedVerticies.Add(start);

            while(stack.Count > 0)
            {
                Vertex target = stack.Pop();

                preOrder.Add(target);

                List<Edge> edgeNeighbors = graph.GetNeighbors(target);

                List<Vertex> vertexNeighbors = new List<Vertex>();

                foreach(Edge edge in edgeNeighbors)
                {
                    vertexNeighbors.Add(edge.Vertex);
                }

                while(FindLowestVertex(vertexNeighbors) != null)
                {
                    Vertex addingToStack = FindLowestVertex(vertexNeighbors);
                    stack.Push(addingToStack);
                    visitedVerticies.Add(addingToStack);
                    vertexNeighbors.Remove(addingToStack);
                }
            }
            return preOrder;
        }
    }
}
