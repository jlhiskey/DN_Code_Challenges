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