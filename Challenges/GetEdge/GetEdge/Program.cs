using System;
using System.Collections.Generic;
using Graph;

namespace GetEdge
{
    public class Program
    {
        static void Main(string[] args)
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

            Console.WriteLine(GetEdge(cities, "Seattle", "Portland"));

            Console.WriteLine(GetEdge(cities, "Seattle", "Houston"));

            Console.WriteLine(GetEdge(cities, "Cheboyban", "Houston"));

            Console.WriteLine(GetEdge(cities, "Seattle", "Pawnee"));

            Console.WriteLine(GetEdge(cities, "Cheboyban", "Pawnee"));

            Console.ReadLine();
        }

        /// <summary>
        /// Accepts a graph and two string inputs of startCity and endCity. Checks if the cities exist and returns a string indicating if a direct flight can be found between the two cities.
        /// </summary>
        /// <param name="cities"></param>
        /// <param name="startingCity"></param>
        /// <param name="endingCity"></param>
        /// <returns>String indicating is a direct flight can be found.</returns>
        public static string GetEdge(Graph.Graph cities, string startingCity, string endingCity)
        {
            //Grab all existing cities
            List<Vertex> allCities = cities.GetVerticies();

            //Containers to hold cities once they are found.
            Vertex foundStart = null;
            Vertex foundEnd = null;

            //Searching cities for start and end cities and populates foundStart and foundEnd if found.
            foreach (Vertex city in allCities)
            {
                if (city.Value == startingCity)
                {
                    foundStart = city;
                }

                if (city.Value == endingCity)
                {
                    foundEnd = city;
                }
            }

            //Handles missing cities
            if(foundStart == null && foundEnd == null)
            {
                return "Starting and Ending Cities Do Not Exist";
            }
            if (foundStart == null)
            {
                return "Starting City Does Not Exist";
            }
            if (foundEnd == null)
            {
                return "Ending City Does Not Exist";
            }

            //Grabs neighbors of start city
            List<Edge> neighbors = cities.GetNeighbors(foundStart);

            //Searches neighbors for end city and returns success if found.
            foreach (Edge neighbor in neighbors)
            {
                if (neighbor.Vertex.Value == endingCity)
                {
                    return $"Direct Route Found, Cost = ${neighbor.Weight}";
                }
            }
           
            //If direct route is not found returns failure.
            return "No Direct Route Found";
        }
    }
}
;