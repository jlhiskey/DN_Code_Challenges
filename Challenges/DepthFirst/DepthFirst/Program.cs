using Graph;
using System;
using System.Collections.Generic;

namespace DepthFirst
{
    public class Program
    {
        static void Main(string[] args)
        {
            Graph.Graph graph = new Graph.Graph();
            Vertex one = new Vertex(1);
            Vertex two = new Vertex(2);
            Vertex three = new Vertex(3);
            Vertex four = new Vertex(4);
            Vertex five = new Vertex(5);
            Vertex six = new Vertex(6);
            Vertex seven = new Vertex(7);
            Vertex eight = new Vertex(8);

            graph.AddVertex(one);
            graph.AddVertex(two);
            graph.AddVertex(three);
            graph.AddVertex(four);
            graph.AddVertex(five);
            graph.AddVertex(six);
            graph.AddVertex(seven);
            graph.AddVertex(eight);

            graph.AddEdge(one, two);
            graph.AddEdge(one, five);
            graph.AddEdge(one, seven);
            graph.AddEdge(two, three);
            graph.AddEdge(two, four);
            graph.AddEdge(five, six);
            graph.AddEdge(seven, eight);

            List<Vertex> preOrder = DepthFirst(graph);

            Console.WriteLine("Pre Order Values");
            foreach(Vertex vertex in preOrder)
            {
                Console.WriteLine(vertex.Value);
            }
            Console.ReadLine();
        }

        /// <summary>
        /// Inputs a graph and returns a pre order list of verticies that were visited in a Depth First Traversal.
        /// </summary>
        /// <param name="graph">Graph where verticies values equal integers</param>
        /// <returns>List of visited verticies listed in pre order</returns>
        public static List<Vertex> DepthFirst(Graph.Graph graph)
        {
            //Will keep track of visited verticies
            HashSet<Vertex> visitedVerticies = new HashSet<Vertex>();

            //Searches list of verticies values and returns lowest value or null if all verticies have already been visited.
            Vertex FindLowestVertex(List<Vertex> listOfVerticies)
            {

                Vertex lowestVertex = null;

                int lowestValue = 0;

                foreach (Vertex vertex in listOfVerticies)
                {
                    if (!visitedVerticies.Contains(vertex))
                    {
                        if (lowestVertex == null)
                        {
                            lowestVertex = vertex;
                            lowestValue = int.Parse(vertex.Value.ToString());
                        }
                        if (int.Parse(vertex.Value.ToString()) < lowestValue)
                        {
                            lowestVertex = vertex;
                            lowestValue = int.Parse(vertex.Value.ToString());
                        }
                    }
                    else
                    {
                        return null;
                    }
                }
                return lowestVertex;
            }

            //Returns null if graph is empty.
            if (graph.Size == 0)
            {
                return null;
            }

            //Container that will hold pre order values
            List<Vertex> preOrder = new List<Vertex>();

            //All verticies in graph
            List<Vertex> allVerticies = graph.GetVerticies();

            //Will hold verticies during traversal
            Stack<Vertex> stack = new Stack<Vertex>();

            //Sets start to lowest valued vertex in graph.
            Vertex start = FindLowestVertex(allVerticies);

            //Adds start value to stack
            stack.Push(start);

            //Adds starting value to visitedVerticies
            visitedVerticies.Add(start);

            //Runs while there are verticies in stack
            while(stack.Count > 0)
            {
                //Sets target to value at top of stack.
                Vertex target = stack.Pop();

                //Adds target to preorder list
                preOrder.Add(target);

                //Grabs targets neighbors
                List<Edge> edgeNeighbors = graph.GetNeighbors(target);

                //Will hold parsed vertex neighbors
                List<Vertex> vertexNeighbors = new List<Vertex>();

                //Captures all edges vertex's and adds them to vertexNeighbors
                foreach(Edge edge in edgeNeighbors)
                {
                    vertexNeighbors.Add(edge.Vertex);
                }

                //Runs while FindLowestVertex is not throwing a null.
                while(FindLowestVertex(vertexNeighbors) != null)
                {
                    //Captures lowest valued vertex from vertexNeighbors that hasnt already been visited
                    Vertex addingToStack = FindLowestVertex(vertexNeighbors);
                    //Adds vertex to stack
                    stack.Push(addingToStack);
                    //Adds vertex to visitedVerticies 
                    visitedVerticies.Add(addingToStack);
                    //Removes vertex from vertexNeighbors memory to conserve space and shorten FindLowestVertex run time.
                    vertexNeighbors.Remove(addingToStack);
                }
            }
            //Returns preOrder list of visited verticies.
            return preOrder;
        }
    }
}
