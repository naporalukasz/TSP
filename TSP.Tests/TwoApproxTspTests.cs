using NUnit.Framework;
using TSP.Core.GraphAlgorithms;
using TSP.Core.Helpers;
using TSP.Core.Tsp;

namespace TSP.Tests
{
    [TestFixture]
    public class TwoApproxTspTests
    {
        [Test]
        // example https://www.math.ku.edu/~jmartin/courses/math105-F11/Lectures/chapter6-part3.pdf
        public void TwoApproxTspTest1()
        {
            var graph = TspTestCases.TestCase1();
            FileProcessing.WriteTspResultToFile(graph, 0, "test1_twoApprox.txt");
            var kruskalAlgorithm = new KruskalAlgorithm();
            var eulerAlgorithm = new EulerPathFinder();
            var graphVisitor = new GraphVisitor();
            var algorithm = new TwoApproxTsp(kruskalAlgorithm, eulerAlgorithm, graphVisitor);
            double cost;
            var result = algorithm.Calculate(graph, out cost);
            Assert.AreEqual(cost, 274);
            FileProcessing.WriteTspResultToFile(result, cost, "test1_twoApprox.Out.txt");
        }
        // https://people.sc.fsu.edu/~jburkardt/datasets/tsp/tsp.html
        [Test]
        public void TwoApproxTspTest2()
        {
            var graph = TspTestCases.TestCase2();
            FileProcessing.WriteTspResultToFile(graph, 0, "test2_twoApprox.txt");
            var kruskalAlgorithm = new KruskalAlgorithm();
            var eulerAlgorithm = new EulerPathFinder();
            var graphVisitor = new GraphVisitor();
            var algorithm = new TwoApproxTsp(kruskalAlgorithm, eulerAlgorithm, graphVisitor);
            double cost;
            var result = algorithm.Calculate(graph, out cost);
            Assert.AreEqual(cost, 14.2853825);
            FileProcessing.WriteTspResultToFile(result, cost, "test2_twoApprox.Out.txt");
        }

        [Test]
        public void TwoApproxTspTest3()
        {
            var graph = TspTestCases.TestCase3();
            FileProcessing.WriteTspResultToFile(graph, 0, "test3_twoApprox.txt");
            var kruskalAlgorithm = new KruskalAlgorithm();
            var eulerAlgorithm = new EulerPathFinder();
            var graphVisitor = new GraphVisitor();
            var algorithm = new TwoApproxTsp(kruskalAlgorithm, eulerAlgorithm, graphVisitor);
            double cost;
            var result = algorithm.Calculate(graph, out cost);
            Assert.AreEqual(cost, 1112);
            FileProcessing.WriteTspResultToFile(result, cost, "test3_twoApprox.Out.txt");
        }

        [Test]
        public void TwoApproxTspTest4()
        {
            var graph = TspTestCases.TestCase4();
            FileProcessing.WriteTspResultToFile(graph, 0, "test4_twoApprox.txt");
            var kruskalAlgorithm = new KruskalAlgorithm();
            var eulerAlgorithm = new EulerPathFinder();
            var graphVisitor = new GraphVisitor();
            var algorithm = new TwoApproxTsp(kruskalAlgorithm, eulerAlgorithm, graphVisitor);
            double cost;
            var result = algorithm.Calculate(graph, out cost);
            Assert.AreEqual(cost, 933);
            FileProcessing.WriteTspResultToFile(result, cost, "test4_twoApprox.Out.txt");
        }

        [Test]
        public void TwoApproxTspTest5()
        {
            var graph = TspTestCases.TestCase5();
            FileProcessing.WriteTspResultToFile(graph, 0, "test5_twoApprox.txt");
            var kruskalAlgorithm = new KruskalAlgorithm();
            var eulerAlgorithm = new EulerPathFinder();
            var graphVisitor = new GraphVisitor();
            var algorithm = new TwoApproxTsp(kruskalAlgorithm, eulerAlgorithm, graphVisitor);
            double cost;
            var result = algorithm.Calculate(graph, out cost);
            Assert.AreEqual(cost, 43974);
            FileProcessing.WriteTspResultToFile(result, cost, "test5_twoApprox.Out.txt");
        }

        [Test]
        public void TwoApproxTspTest6()
        {
            var graph = TspTestCases.TestCase6();
            FileProcessing.WriteTspResultToFile(graph, 0, "test6_twoApprox.txt");
            var kruskalAlgorithm = new KruskalAlgorithm();
            var eulerAlgorithm = new EulerPathFinder();
            var graphVisitor = new GraphVisitor();
            var algorithm = new TwoApproxTsp(kruskalAlgorithm, eulerAlgorithm, graphVisitor);
            double cost;
            var result = algorithm.Calculate(graph, out cost);
            Assert.AreEqual(cost, 2352);
            FileProcessing.WriteTspResultToFile(result, cost, "test6_twoApprox.Out.txt");
        }
    }
}
