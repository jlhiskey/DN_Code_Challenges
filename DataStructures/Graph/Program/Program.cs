using System;
using System.Collections.Generic;
using Graph;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph.Graph graph = new Graph.Graph();

            Vertex vertexOne = new Vertex("Hello");
            Vertex vertexTwo = new Vertex("World");
            Vertex vertexThree = new Vertex("Up");
            Vertex vertexFour = new Vertex("What's");
            Vertex vertexFive = new Vertex("I'm an Island");

            graph.AddVertex(vertexOne);
            graph.AddVertex(vertexTwo);
            graph.AddVertex(vertexThree);
            graph.AddVertex(vertexFour);
            graph.AddVertex(vertexFive);

            graph.AddEdge(vertexOne, vertexTwo);
            graph.AddEdge(vertexTwo, vertexThree);
            graph.AddEdge(vertexTwo, vertexFour);

            List<Vertex> visitedVerticies = graph.BreadthFirstTraversal(vertexOne);

            foreach (Vertex vertex in visitedVerticies)
            {
                Console.WriteLine(vertex.Value);
            }

            Console.ReadLine();
        }
    }
}
