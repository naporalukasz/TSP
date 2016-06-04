using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TSP.Core.GraphAlgorithms;
using TSP.Core.Model;

namespace TSP.Tests
{
    [TestFixture]
    public class KruskalTests
    {
        [Test]
        public void Test()
        {
            var list2 = new List<Edge>()
            {
                new Edge(){ From=0,To=1,Weight=7 },
                new Edge(){ From=0,To=3,Weight=5 },
                new Edge(){ From=1,To=2,Weight=8 },
                new Edge(){ From=1,To=4,Weight=7 },
                new Edge(){ From=1,To=3,Weight=7 },
                new Edge(){ From=2,To=4,Weight=5 },
                new Edge(){ From=3,To=5,Weight=6 },
                new Edge(){ From=3,To=4,Weight=15 },
                new Edge(){ From=4,To=5,Weight=8 },
                new Edge(){ From=5,To=6,Weight=11 },
                new Edge(){ From=4,To=6,Weight=9 }
            };
            var graph = new Graph(list2, 7);
            var kruskalAlgorithm = new KruskalAlgorithm();
            var kruskalResult = kruskalAlgorithm.CalculateMst(graph);
        }
    }
}
