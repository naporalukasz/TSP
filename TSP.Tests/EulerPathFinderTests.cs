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
    public class EulerPathFinderTests
    {
        [Test]
        public void TestEuler()
        {
            var edges = new List<Edge>()
            {
                new Edge { From=0,To=1,Weight=1 },
                new Edge { From=1,To=3,Weight=1 },
                new Edge { From=1,To=4,Weight=1 },
                new Edge { From=2,To=1,Weight=1 },
                new Edge { From=2,To=5,Weight=1 },
                new Edge { From=3,To=0,Weight=1 },
                new Edge { From=3,To=2,Weight=1 },
                new Edge { From=3,To=7,Weight=1 },
                new Edge { From=4,To=2,Weight=1 },
                new Edge { From=4,To=3,Weight=1 },
                new Edge { From=4,To=6,Weight=1 },
                new Edge { From=5,To=4,Weight=1 },
                new Edge { From=5,To=7,Weight=1 },
                new Edge { From=6,To=3,Weight=1 },
                new Edge { From=7,To=4,Weight=1 },
                new Edge { From=7,To=8,Weight=1 },
                new Edge { From=8,To=5,Weight=1 },
            };
            var euler = new EulerPathFinder();
            var duplicatedEdgesGraph = new Graph { Edges = new List<Edge>(edges) };
            var eulerPath = euler.FindPath(duplicatedEdgesGraph);
            Assert.AreEqual(eulerPath.Edges.First().From, eulerPath.Edges.Last().To);
        }
    }
}
