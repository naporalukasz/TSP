using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TSP.Core.GraphAlgorithms;
using TSP.Core.Model;
using TSP.Core.Tsp;

namespace TSP.Tests
{
    
    [TestFixture]
    public class MinimalMatchingTests
    {
        [Test]
        // example https://www.math.ku.edu/~jmartin/courses/math105-F11/Lectures/chapter6-part3.pdf
        public void MinimalMatchingTest()
        {
            var edges = new List<Edge>()
        {
           
            new Edge { From=0,To=1,Weight=45 },
            new Edge { From=0,To=2,Weight=40 },
            new Edge { From=0,To=3,Weight=92 },
            new Edge { From=0,To=4,Weight=71 },
            new Edge { From=0,To=5,Weight=67 },

            new Edge { From=1,To=2,Weight=20 },
            new Edge { From=1,To=3,Weight=50 },
            new Edge { From=1,To=4,Weight=42 },
            new Edge { From=1,To=5,Weight=54 },

            new Edge { From=2,To=3,Weight=54 },
            new Edge { From=2,To=4,Weight=32 },
            new Edge { From=2,To=5,Weight=36 },

            new Edge { From=3,To=4,Weight=36 },
            new Edge { From=3,To=5,Weight=58 },

            new Edge { From=4,To=5,Weight=22 },
        };
            var graph = new Graph(edges, 6);
            var kruskalAlgorithm = new KruskalAlgorithm();
            var eulerAlgorithm = new EulerPathFinder();
            var minimal = new MinimalMatching();
            var graphVisitor = new GraphVisitor();
            var algorithm = new ChristofidesTsp(kruskalAlgorithm, minimal, eulerAlgorithm, graphVisitor);
            double cost;
            var result = algorithm.Calculate(graph, out cost);
            Assert.AreNotEqual(cost, 243);
        }
    }
    
}
