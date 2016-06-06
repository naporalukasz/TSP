using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSP.Core.Model;
using TSP.Core.Tsp;

namespace TSP.Core.Helpers
{
    public static class ConsoleProcessing
    {
        public static Graph ReadConsole(out AlgorithmType algorithmType)
        {
            Console.WriteLine("Podaj numer algorytmu ('2-aproksymacyjny' - 0, Chrystofides - 1");
            GetAlgorithmType(out algorithmType);
            Console.WriteLine("Podaj liczbę wierzchołków oraz liczbę krawędzi grafu");
            var readLine = Console.ReadLine();
            int edgesCount = 0, verticesCount = 0;
            if (readLine != null)
            {
                var edgesAndVerticesString = readLine.Split(' ');
                verticesCount = int.Parse(edgesAndVerticesString[0]);
                edgesCount = int.Parse(edgesAndVerticesString[1]);
            }
            var graph = new Graph(GetEdges(edgesCount), verticesCount);
            return graph;
        }

        private static void GetAlgorithmType(out AlgorithmType algorithmType)
        {
            var algorithmNumberString = Console.ReadLine();
            var algorithmNumber = 0;
            if (algorithmNumberString != null)
                algorithmNumber = int.Parse(algorithmNumberString);
            algorithmType = (AlgorithmType)algorithmNumber;
        }

        private static List<Edge> GetEdges(int edgesCount)
        {
            Console.WriteLine("Podaj opis krawędzi w formacie x y z (x, y - numery wierzchołków numerowane od zera, z - waga krawędzi");
            var edges = new List<Edge>();
            for (var i = 0; i < edgesCount; i++)
            {
                var edgeLine = Console.ReadLine();
                var edgeStrings = edgeLine.Split(' ');
                var edgeFrom = int.Parse(edgeStrings[0]);
                var edgeTo = int.Parse(edgeStrings[1]);
                var weight = double.Parse(edgeStrings[2]);
                edges.Add(new Edge(edgeFrom, edgeTo, weight));
            }
            return edges;
        }


    }
}
