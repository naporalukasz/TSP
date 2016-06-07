using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TSP.Core.GraphAlgorithms;
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
            var kruskalAlgorithm = new KruskalAlgorithm();
            var eulerAlgorithm = new EulerPathFinder();
            var minimal = new MinimalMatching();
            var graphVisitor = new GraphVisitor();
            var algorithm = new ChristofidesTsp(kruskalAlgorithm, minimal, eulerAlgorithm, graphVisitor);
            double cost;
            var result = algorithm.Calculate(graph, out cost);
            Assert.AreEqual(cost, 244);
        }
        // https://people.sc.fsu.edu/~jburkardt/datasets/tsp/tsp.html
        [Test]
        public void ChristofidesTspTest2()
        {
            var graph = TspTestCases.TestCase2();
            var kruskalAlgorithm = new KruskalAlgorithm();
            var eulerAlgorithm = new EulerPathFinder();
            var minimal = new MinimalMatching();
            var graphVisitor = new GraphVisitor();
            var algorithm = new ChristofidesTsp(kruskalAlgorithm, minimal, eulerAlgorithm, graphVisitor);
            double cost;
            var result = algorithm.Calculate(graph, out cost);
            Assert.AreEqual(cost, 14.2853825);
        }

        [Test]
        public void ChristofidesTspTest3()
        {
            var graph = TspTestCases.TestCase3();
            var kruskalAlgorithm = new KruskalAlgorithm();
            var eulerAlgorithm = new EulerPathFinder();
            var minimal = new MinimalMatching();
            var graphVisitor = new GraphVisitor();
            var algorithm = new ChristofidesTsp(kruskalAlgorithm, minimal, eulerAlgorithm, graphVisitor);
            double cost;
            var result = algorithm.Calculate(graph, out cost);
            Assert.AreEqual(cost, 1118);
        }

        [Test]
        public void ChristofidesTspTest4()
        {
            var graph = TspTestCases.TestCase4();
            var kruskalAlgorithm = new KruskalAlgorithm();
            var eulerAlgorithm = new EulerPathFinder();
            var minimal = new MinimalMatching();
            var graphVisitor = new GraphVisitor();
            var algorithm = new ChristofidesTsp(kruskalAlgorithm, minimal, eulerAlgorithm, graphVisitor);
            double cost;
            var result = algorithm.Calculate(graph, out cost);
            Assert.AreEqual(cost, 769);
        }
        [Test]
        public void ChristofidesTspTest5()
        {
            var graph = TspTestCases.TestCase5();
            var kruskalAlgorithm = new KruskalAlgorithm();
            var eulerAlgorithm = new EulerPathFinder();
            var minimal = new MinimalMatching();
            var graphVisitor = new GraphVisitor();
            var algorithm = new ChristofidesTsp(kruskalAlgorithm, minimal, eulerAlgorithm, graphVisitor);
            double cost;
            var result = algorithm.Calculate(graph, out cost);
            Assert.AreEqual(cost, 37715);
        }

        [Test]
        public void ChristofidesTspTest6()
        {
            var graph = TspTestCases.TestCase6();
            var kruskalAlgorithm = new KruskalAlgorithm();
            var eulerAlgorithm = new EulerPathFinder();
            var minimal = new MinimalMatching();
            var graphVisitor = new GraphVisitor();
            var algorithm = new ChristofidesTsp(kruskalAlgorithm, minimal, eulerAlgorithm, graphVisitor);
            double cost;
            var result = algorithm.Calculate(graph, out cost);
            Assert.AreEqual(cost, 1386);
        }

    }
}
