using System;
using Xunit;
using Graph;
using GetEdge;

namespace GetEdgeTestSuite
{
    public class UnitTest1
    {
        public Graph.Graph CreateGraph()
        {
            Graph.Graph cities = new Graph.Graph();

            Vertex seattle = new Vertex("Seattle");
            Vertex portland = new Vertex("Portland");
            Vertex houston = new Vertex("Houston");

            cities.AddVertex(seattle);
            cities.AddVertex(portland);
            cities.AddVertex(houston);

            cities.AddEdge(seattle, portland, 100);
            cities.AddEdge(portland, houston, 200);

            return cities;
        }
        



        [Fact]
        public void DirectFlightFound()
        {
            Graph.Graph cities = CreateGraph();        

            Assert.Equal("Direct Route Found, Cost = $100", Program.GetEdge(cities, "Seattle", "Portland"));
        }

        [Fact]
        public void BothCitiesExistButNoDirectFlight()
        {
            Graph.Graph cities = CreateGraph();

            Assert.Equal("No Direct Route Found", Program.GetEdge(cities, "Seattle", "Houston"));
        }

        [Fact]
        public void StartCityDoesntExist()
        {
            Graph.Graph cities = CreateGraph();

            Assert.Equal("Starting City Does Not Exist", Program.GetEdge(cities, "Cheboyban", "Houston"));
        }

        [Fact]
        public void FinishCityDoesntExist()
        {
            Graph.Graph cities = CreateGraph();

            Assert.Equal("Ending City Does Not Exist", Program.GetEdge(cities, "Seattle", "Pawnee"));
        }

        [Fact]
        public void StartAndFinishCityDontExist()
        {
            Graph.Graph cities = CreateGraph();

            Assert.Equal("Starting and Ending Cities Do Not Exist", Program.GetEdge(cities, "Cheboyban", "Pawnee"));
        }
    }
}
