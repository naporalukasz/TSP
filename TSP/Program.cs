using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSP.Core;
using TSP.Core.Helpers;
using TSP.Core.Model;

namespace TSP
{
    class Program
    {
        static void Main(string[] args)
        {
            AlgorithmType algorithmType;
            Graph graph;

            Console.WriteLine("Podaj typ wczytywania danych (0 - wpisanie ręczne, 1 - podanie z pliku)");
            var enterDataTypeString = Console.ReadLine();
            var enterDataNumber = 0;
            if (enterDataTypeString != null)
                enterDataNumber = int.Parse(enterDataTypeString);
            if (enterDataNumber == 0)
                graph = ConsoleProcessing.ReadConsole(out algorithmType);
            else
            {
                Console.WriteLine("Podaj ścieżkę do pliku (względną lub bezwzględną)");
                var path = Console.ReadLine();
                graph = FileProcessing.ReadGraphFromFile(path, out algorithmType);
            }
            var algorithm = TspAlgorithmFactory.CreateAlgorithm(algorithmType);
            double cost;
            var tspGraph = algorithm.Calculate(graph, out cost);
            FileProcessing.WriteTspResultToFile(tspGraph, cost, $"test_{algorithmType}_{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.txt");
            Console.WriteLine($"Koszt {cost}");
            Console.WriteLine();
        }
    }
}
