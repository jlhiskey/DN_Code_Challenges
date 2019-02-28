using Graph;
using System;
using System.Collections.Generic;
using Xunit;
using DepthFirst;

namespace DepthFirstTestSuite
{
    public class UnitTest1
    {
        [Fact]
        public void TestingWhereAllVerticiesHaveAtLeastOneEdgeAndOneHasTwoEdges()
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

            List<Vertex> expected = new List<Vertex>();

            expected.Add(one);
            expected.Add(two);
            expected.Add(five);
            expected.Add(three);
            expected.Add(four);            

            List<Vertex> actual = Program.DepthFirst(graph);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestingWhereAllVerticiesHaveAtLeastOneEdgeAndOneHasThreeEdgesAndOneHasTwoEdges()
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
            
            List<Vertex> expected = new List<Vertex>();

            expected.Add(one);
            expected.Add(seven);
            expected.Add(eight);
            expected.Add(five);
            expected.Add(six);
            expected.Add(two);          
            expected.Add(four);
            expected.Add(three);

            List<Vertex> actual = Program.DepthFirst(graph);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestingAnEmptyGraph()
        {
            Graph.Graph graph = new Graph.Graph();

            Assert.Null(Program.DepthFirst(graph));
        }
    }
}
