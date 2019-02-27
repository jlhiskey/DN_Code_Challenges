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

        public static string GetEdge(Graph.Graph cities, string startingCity, string endingCity)
        {
            List<Vertex> allCities = cities.GetVerticies();
            bool startExists = false;
            Vertex foundStart = null;
            bool endExists = false;
            Vertex foundFinish = null;
            foreach (Vertex city in allCities)
            {
                if (city.Value == startingCity)
                {
                    startExists = true;
                    foundStart = city;
                }

                if (city.Value == endingCity)
                {
                    endExists = true;
                    foundFinish = city;
                }
            }

            if(!startExists && !endExists)
            {
                return "Starting and Ending Cities Do Not Exist";
            }
            if (!startExists)
            {
                return "Starting City Does Not Exist";
            }
            if (!endExists)
            {
                return "Ending City Does Not Exist";
            }
            
            if(foundStart != null)
            {
                List<Edge> neighbors = cities.GetNeighbors(foundStart);

                foreach (Edge neighbor in neighbors)
                {
                    if (neighbor.Vertex.Value == endingCity)
                    {
                        return $"Direct Route Found, Cost = ${neighbor.Weight}";
                    }
                }
            }
            
            return "No Direct Route Found";
        }
    }
}
;