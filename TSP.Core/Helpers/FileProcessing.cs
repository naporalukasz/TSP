using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TSP.Core.Model;

namespace TSP.Core.Helpers
{
    public static class FileProcessing
    {
        public static Graph ReadGraphFromFile(string path, out AlgorithmType algorithmType)
        {
            try
            {
                using (var sr = new StreamReader(path))
                {
                    var edges = new List<Edge>();
                    algorithmType = GetAlgorithmType(sr);
                    var maxVertexIndex = 0;
                    string line;

                    if (!sr.EndOfStream)
                        sr.ReadLine();

                    while ((line = sr.ReadLine()) != null)
                    {
                        var edgeStrings = line.Split(' ');
                        var edgeFrom = int.Parse(edgeStrings[0]);
                        var edgeTo = int.Parse(edgeStrings[1]);
                        var weight = double.Parse(edgeStrings[2]);
                        edges.Add(new Edge(edgeFrom, edgeTo, weight));
                        maxVertexIndex = Math.Max(maxVertexIndex, edgeFrom);
                        maxVertexIndex = Math.Max(maxVertexIndex, edgeTo);
                    }
                    sr.Close();

                    return new Graph(edges, maxVertexIndex + 1);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(@"Podczas przetwarzania pliku z danymi wystapił błąd:");
                Console.WriteLine(e.Message);

                algorithmType = AlgorithmType.TwoApprox;
                return null;
            }
        }

        private static AlgorithmType GetAlgorithmType(StreamReader streamReader)
        {
            var algorithmNumberString = streamReader.ReadLine();
            var algorithmNumber = 0;
            if (algorithmNumberString != null)
                algorithmNumber = int.Parse(algorithmNumberString);
            return (AlgorithmType)algorithmNumber;
        }

        public static bool WriteTspResultToFile(Graph graph, double cost, string path)
        {
            try
            {
                using (var writetext = new StreamWriter(path))
                {
                    writetext.WriteLine($"{graph.VerticesCount} {graph.Edges.Count}");
                    foreach (var edge in graph.Edges)
                        writetext.WriteLine($"{edge.From} {edge.To} {edge.Weight}");
                    writetext.WriteLine($"Cost {cost}");
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(@"Podczas przetwarzania pliku z danymi wystapił błąd:");
                Console.WriteLine(e.Message);

                return false;
            }

        }
    }
}
