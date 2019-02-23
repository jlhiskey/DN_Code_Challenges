using System;
using Xunit;
using Graph;
using System.Collections.Generic;

namespace GraphTestSuite
{
    public class GraphTestSuite
    {
        [Fact]
        public void VertexCanBeAdded()
        {
            Graph.Graph graph = new Graph.Graph();

            Vertex newVertex = new Vertex("Hello");

            graph.AddVertex(newVertex);

            List<Vertex> expected = new List<Vertex>();
            expected.Add(newVertex);

            List<Vertex> actual = graph.GetVertices();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EdgeCanBeAdded()        
        {
            Graph.Graph graph = new Graph.Graph();

            Vertex vertexOne = new Vertex("Hello");
            Vertex vertexTwo = new Vertex("World");

            graph.AddVertex(vertexOne);
            graph.AddVertex(vertexTwo);

            graph.AddEdge(vertexOne, vertexTwo, 10);

            Edge edgeOne = new Edge(vertexTwo, 10);

            List<Edge> expected = new List<Edge>();
            expected.Add(edgeOne);

            List<Edge> actual = graph.GetNeighbors(vertexOne);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AllVerticiesCanBeRetreived()
        {
            Graph.Graph graph = new Graph.Graph();

            Vertex vertexOne = new Vertex("Hello");
            Vertex vertexTwo = new Vertex("World");

            graph.AddVertex(vertexOne);
            graph.AddVertex(vertexTwo);

            List<Vertex> expected = new List<Vertex>();
            expected.Add(vertexOne);
            expected.Add(vertexTwo);

            List<Vertex> actual = graph.GetVertices();

            Assert.Equal(expected, actual);

        }

        [Fact]
        public void AllNeighborsCanBeRetreivedFromVertex()
        {
            Graph.Graph graph = new Graph.Graph();

            Vertex vertexOne = new Vertex("Hello");
            Vertex vertexTwo = new Vertex("World");
            Vertex vertexThree = new Vertex(17);

            graph.AddVertex(vertexOne);
            graph.AddVertex(vertexTwo);
            graph.AddVertex(vertexThree);

            graph.AddEdge(vertexOne, vertexTwo, 10);
            graph.AddEdge(vertexOne, vertexThree, 15);

            Edge edgeOne = new Edge(vertexTwo, 10);
            Edge edgeTwo = new Edge(vertexTwo, 15);

            List<Edge> expected = new List<Edge>();
            expected.Add(edgeOne);
            expected.Add(edgeTwo);

            List<Edge> actual = graph.GetNeighbors(vertexOne);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NeighborsRetreivedContainWeightData()
        {
            Graph.Graph graph = new Graph.Graph();

            Vertex vertexOne = new Vertex("Hello");
            Vertex vertexTwo = new Vertex("World");
            Vertex vertexThree = new Vertex(17);

            graph.AddVertex(vertexOne);
            graph.AddVertex(vertexTwo);
            graph.AddVertex(vertexThree);

            graph.AddEdge(vertexOne, vertexTwo, 10);
            graph.AddEdge(vertexOne, vertexThree, 15);

            Edge edgeOne = new Edge(vertexTwo, 10);
            Edge edgeTwo = new Edge(vertexTwo, 15);

            List<Edge> expected = new List<Edge>();         
            expected.Add(edgeTwo);
            expected.Add(edgeOne);

            List<int> expectedWeight = new List<int>();
            foreach(Edge edge in expected)
            {
                expectedWeight.Add(edge.Weight);
            }

            List<Edge> actual = graph.GetNeighbors(vertexOne);

            List<int> actualWeight = new List<int>();
            foreach (Edge edge in actual)
            {
                actualWeight.Add(edge.Weight);
            }

            Assert.Equal(expectedWeight, actualWeight);
        }

        [Fact]
        public void ProperSizeIsReturned()
        {
            Graph.Graph graph = new Graph.Graph();

            Vertex vertexOne = new Vertex("Hello");
            Vertex vertexTwo = new Vertex("World");
            Vertex vertexThree = new Vertex(17);

            graph.AddVertex(vertexOne);
            graph.AddVertex(vertexTwo);
            graph.AddVertex(vertexThree);

            Assert.Equal(3, graph.GetSize());
        }

        [Fact]
        public void AGraphWithOneVertexAndOneEdgeCanBeReturned()
        {
            Graph.Graph graph = new Graph.Graph();

            Vertex vertexOne = new Vertex("Hello");
            graph.AddEdge(vertexOne, vertexOne, 10);

            Edge edgeOne = new Edge(vertexOne, 10);

            List<Edge> expected = new List<Edge>();
            expected.Add(edgeOne);

            List<Edge> actual = graph.GetNeighbors(vertexOne);

            Assert.Equal(expected, expected);
        }

        [Fact]
        public void EmptyGraphReturnsNull()
        {

        }
    }
}
