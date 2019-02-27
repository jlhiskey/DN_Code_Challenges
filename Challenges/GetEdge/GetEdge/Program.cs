using System;
using System.Collections.Generic;
using Graph;

namespace GetEdge
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public string GetEdge(Graph.Graph cities, Vertex startingCity, Vertex endingCity)
        {
            if(!cities._AdjacencyList.ContainsKey(startingCity))
            {
                return "Starting City not found";
            }

            if (!cities._AdjacencyList.ContainsKey(endingCity))
            {
                return "Ending City not found";
            }

            List<Edge> neighbors = cities.GetNeighbors(startingCity);

            foreach (Edge neighbor in neighbors)
            {
                if(neighbor.Vertex == endingCity)
                {
                    return $"Direct Route Found, Cost = ${neighbor.Weight}";
                }
            }
            return "No Direct Route Found";
        }
    }
}
;