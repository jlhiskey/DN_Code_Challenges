using System;
using Xunit;
using Graph;
using System.Collections.Generic;

namespace BreadthFirstTestSuite
{
    public class BreadthFirstTestSuite
    {
        [Fact]
        public void TestingWithTwoVerticiesOneEdge()
        {
            Graph.Graph graph = new Graph.Graph();

            Vertex vertexOne = new Vertex("Hello");
            Vertex vertexTwo = new Vertex("World");

            graph.AddVertex(vertexOne);
            graph.AddVertex(vertexTwo);

            graph.AddEdge(vertexOne, vertexTwo, 10);

            List<Vertex> expected = new List<Vertex>();
            expected.Add(vertexOne);
            expected.Add(vertexTwo);

            List<Vertex> actual = graph.BreadthFirst(vertexOne);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestingWithFourVerticiesWithSecondVerticeHaveingTwoEdges()
        {
            Graph.Graph graph = new Graph.Graph();

            Vertex vertexOne = new Vertex("Hello");
            Vertex vertexTwo = new Vertex("World");
            Vertex vertexThree = new Vertex("What's");
            Vertex vertexFour = new Vertex("Up");

            graph.AddVertex(vertexOne);
            graph.AddVertex(vertexTwo);
            graph.AddVertex(vertexThree);
            graph.AddVertex(vertexFour);

            graph.AddEdge(vertexOne, vertexTwo);
            graph.AddEdge(vertexTwo, vertexThree);
            graph.AddEdge(vertexTwo, vertexFour);


            List<Vertex> expected = new List<Vertex>();
            expected.Add(vertexOne);
            expected.Add(vertexTwo);           
            expected.Add(vertexFour);
            expected.Add(vertexThree);

            List<Vertex> actual = graph.BreadthFirst(vertexOne);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestingWithFourVerticiesWithSecondVerticeHaveingTwoEdgesWithFinalVertexPointingBackToStartVertex()
        {
            Graph.Graph graph = new Graph.Graph();

            Vertex vertexOne = new Vertex("Hello");
            Vertex vertexTwo = new Vertex("World");
            Vertex vertexThree = new Vertex("What's");
            Vertex vertexFour = new Vertex("Up");

            graph.AddVertex(vertexOne);
            graph.AddVertex(vertexTwo);
            graph.AddVertex(vertexThree);
            graph.AddVertex(vertexFour);

            graph.AddEdge(vertexOne, vertexTwo);
            graph.AddEdge(vertexTwo, vertexThree);
            graph.AddEdge(vertexTwo, vertexFour);
            graph.AddEdge(vertexFour, vertexOne);


            List<Vertex> expected = new List<Vertex>();
            expected.Add(vertexOne);
            expected.Add(vertexTwo);
            expected.Add(vertexFour);
            expected.Add(vertexThree);

            List<Vertex> actual = graph.BreadthFirst(vertexOne);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestingWithFourVerticiesThatAreConnectedAndOneVerticeThatIsAnIsland()
        {
            Graph.Graph graph = new Graph.Graph();

            Vertex vertexOne = new Vertex("Hello");
            Vertex vertexTwo = new Vertex("World");
            Vertex vertexThree = new Vertex("What's");
            Vertex vertexFour = new Vertex("Up");
            Vertex vertexFive = new Vertex("Im an Island");

            graph.AddVertex(vertexOne);
            graph.AddVertex(vertexTwo);
            graph.AddVertex(vertexThree);
            graph.AddVertex(vertexFour);
            graph.AddVertex(vertexFive);

            graph.AddEdge(vertexOne, vertexTwo);
            graph.AddEdge(vertexTwo, vertexThree);
            graph.AddEdge(vertexTwo, vertexFour);


            List<Vertex> expected = new List<Vertex>();
            expected.Add(vertexOne);
            expected.Add(vertexTwo);
            expected.Add(vertexFour);
            expected.Add(vertexThree);

            List<Vertex> actual = graph.BreadthFirst(vertexOne);

            Assert.Equal(expected, actual);
        }
    }
}
