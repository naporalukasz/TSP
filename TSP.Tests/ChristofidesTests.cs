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
            Assert.AreEqual(cost, 43974);
        }
    }
}
