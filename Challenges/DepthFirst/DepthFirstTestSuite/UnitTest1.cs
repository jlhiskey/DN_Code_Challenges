using Graph;
using System;
using Xunit;

namespace DepthFirstTestSuite
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Graph.Graph graph = new Graph.Graph();
            Vertex one = new Vertex(1);
            Vertex two = new Vertex(2);
            Vertex three = new Vertex(3);
            Vertex four = new Vertex(4);
            Vertex five = new Vertex(5);

            graph.AddVertex(one);
            graph.AddVertex(two);
            graph.AddVertex(three);
            graph.AddVertex(four);
            graph.AddVertex(five);

            graph.AddEdge(one, two);
            graph.AddEdge(two, five);
            graph.AddEdge(two, three);
            graph.AddEdge(three, four);

            List<Vertex> 

        }
    }
}
