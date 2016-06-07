using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TSP.Core.GraphAlgorithms;
using TSP.Core.Helpers;
using TSP.Core.Tsp;

namespace TSP.Tests
{
    [TestFixture]
    public class ChristofidesTests
    {

        [Test]
        // example https://www.math.ku.edu/~jmartin/courses/math105-F11/Lectures/chapter6-part3.pdf
        public void ChristofidesTspTest1()
        {
            var graph = TspTestCases.TestCase1();
            FileProcessing.WriteTspResultToFile(graph, 0, "test1_christofides.txt");
            var kruskalAlgorithm = new KruskalAlgorithm();
            var eulerAlgorithm = new EulerPathFinder();
            var minimal = new MinimalMatching();
            var graphVisitor = new GraphVisitor();
            var algorithm = new ChristofidesTsp(kruskalAlgorithm, minimal, eulerAlgorithm, graphVisitor);
            double cost;
            var result = algorithm.Calculate(graph, out cost);
            Assert.AreEqual(cost, 290);
            FileProcessing.WriteTspResultToFile(result, cost, "test1_christofides.Out.txt");

        }
        // https://people.sc.fsu.edu/~jburkardt/datasets/tsp/tsp.html
        [Test]
        public void ChristofidesTspTest2()
        {
            var graph = TspTestCases.TestCase2();
            FileProcessing.WriteTspResultToFile(graph, 0, "test2_christofides.txt");
            var kruskalAlgorithm = new KruskalAlgorithm();
            var eulerAlgorithm = new EulerPathFinder();
            var minimal = new MinimalMatching();
            var graphVisitor = new GraphVisitor();
            var algorithm = new ChristofidesTsp(kruskalAlgorithm, minimal, eulerAlgorithm, graphVisitor);
            double cost;
            var result = algorithm.Calculate(graph, out cost);
            Assert.AreEqual(cost, 14.2853825);
            FileProcessing.WriteTspResultToFile(result, cost, "test2_christofides.Out.txt");

        }

        [Test]
        public void ChristofidesTspTest3()
        {
            var graph = TspTestCases.TestCase3();
            FileProcessing.WriteTspResultToFile(graph, 0, "test3_christofides.txt");
            var kruskalAlgorithm = new KruskalAlgorithm();
            var eulerAlgorithm = new EulerPathFinder();
            var minimal = new MinimalMatching();
            var graphVisitor = new GraphVisitor();
            var algorithm = new ChristofidesTsp(kruskalAlgorithm, minimal, eulerAlgorithm, graphVisitor);
            double cost;
            var result = algorithm.Calculate(graph, out cost);
            Assert.AreEqual(cost, 1192);
            FileProcessing.WriteTspResultToFile(result, cost, "test3_christofides.Out.txt");

        }

        [Test]
        public void ChristofidesTspTest4()
        {
            var graph = TspTestCases.TestCase4();
            FileProcessing.WriteTspResultToFile(graph, 0, "test4_christofides.txt");
            var kruskalAlgorithm = new KruskalAlgorithm();
            var eulerAlgorithm = new EulerPathFinder();
            var minimal = new MinimalMatching();
            var graphVisitor = new GraphVisitor();
            var algorithm = new ChristofidesTsp(kruskalAlgorithm, minimal, eulerAlgorithm, graphVisitor);
            double cost;
            var result = algorithm.Calculate(graph, out cost);
            Assert.AreEqual(cost,848);
            FileProcessing.WriteTspResultToFile(result, cost, "test4_christofides.Out.txt");

        }
        [Test]
        public void ChristofidesTspTest5()
        {
            var graph = TspTestCases.TestCase5();
            FileProcessing.WriteTspResultToFile(graph, 0, "test5_christofides.txt");
            var kruskalAlgorithm = new KruskalAlgorithm();
            var eulerAlgorithm = new EulerPathFinder();
            var minimal = new MinimalMatching();
            var graphVisitor = new GraphVisitor();
            var algorithm = new ChristofidesTsp(kruskalAlgorithm, minimal, eulerAlgorithm, graphVisitor);
            double cost;
            var result = algorithm.Calculate(graph, out cost);
            Assert.AreEqual(cost, 41991);
            FileProcessing.WriteTspResultToFile(result, cost, "test5_christofides.Out.txt");

        }

        [Test]
        public void ChristofidesTspTest6()
        {
            var graph = TspTestCases.TestCase6();
            FileProcessing.WriteTspResultToFile(graph, 0, "test6_christofides.txt");
            var kruskalAlgorithm = new KruskalAlgorithm();
            var eulerAlgorithm = new EulerPathFinder();
            var minimal = new MinimalMatching();
            var graphVisitor = new GraphVisitor();
            var algorithm = new ChristofidesTsp(kruskalAlgorithm, minimal, eulerAlgorithm, graphVisitor);
            double cost;
            var result = algorithm.Calculate(graph, out cost);
            Assert.AreEqual(cost, 2257);
            FileProcessing.WriteTspResultToFile(result, cost, "test6_christofides.Out.txt");

        }

    }
}
