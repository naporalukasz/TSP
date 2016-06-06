using NUnit.Framework;
using TSP.Core.GraphAlgorithms;
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
            var kruskalAlgorithm = new KruskalAlgorithm();
            var eulerAlgorithm = new EulerPathFinder();
            var graphVisitor = new GraphVisitor();
            var algorithm = new TwoApproxTsp(kruskalAlgorithm, eulerAlgorithm, graphVisitor);
            double cost;
            var result = algorithm.Calculate(graph, out cost);
            Assert.AreEqual(cost, 274);
        }

        [Test]
        public void TwoApproxTspTest2()
        {
            var graph = TspTestCases.TestCase2();
            var kruskalAlgorithm = new KruskalAlgorithm();
            var eulerAlgorithm = new EulerPathFinder();
            var graphVisitor = new GraphVisitor();
            var algorithm = new TwoApproxTsp(kruskalAlgorithm, eulerAlgorithm, graphVisitor);
            double cost;
            var result = algorithm.Calculate(graph, out cost);
            Assert.AreEqual(cost, 14.2853825);
        }

        [Test]
        public void TwoApproxTspTest3()
        {
            var graph = TspTestCases.TestCase3();
            var kruskalAlgorithm = new KruskalAlgorithm();
            var eulerAlgorithm = new EulerPathFinder();
            var graphVisitor = new GraphVisitor();
            var algorithm = new TwoApproxTsp(kruskalAlgorithm, eulerAlgorithm, graphVisitor);
            double cost;
            var result = algorithm.Calculate(graph, out cost);
            Assert.AreEqual(cost, 1112);
        }

        [Test]
        public void TwoApproxTspTest4()
        {
            var graph = TspTestCases.TestCase4();
            var kruskalAlgorithm = new KruskalAlgorithm();
            var eulerAlgorithm = new EulerPathFinder();
            var graphVisitor = new GraphVisitor();
            var algorithm = new TwoApproxTsp(kruskalAlgorithm, eulerAlgorithm, graphVisitor);
            double cost;
            var result = algorithm.Calculate(graph, out cost);
            Assert.AreEqual(cost, 933);
        }

        [Test]
        public void TwoApproxTspTest5()
        {
            var graph = TspTestCases.TestCase5();
            var kruskalAlgorithm = new KruskalAlgorithm();
            var eulerAlgorithm = new EulerPathFinder();
            var graphVisitor = new GraphVisitor();
            var algorithm = new TwoApproxTsp(kruskalAlgorithm, eulerAlgorithm, graphVisitor);
            double cost;
            var result = algorithm.Calculate(graph, out cost);
            Assert.AreEqual(cost, 43974);
        }
    }
}
