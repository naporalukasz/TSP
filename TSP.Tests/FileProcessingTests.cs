using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TSP.Core;
using TSP.Core.Helpers;
using TSP.Core.Model;

namespace TSP.Tests
{
    [TestFixture]
    public class FileProcessingTests
    {
        [Test]
        public void TestReadGraphFromFile()
        {
            var edges = new List<Edge>
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
            AlgorithmType algorithmType;
            var graph = FileProcessing.ReadGraphFromFile("..//..//test.txt", out algorithmType);
            for (var i = 0; i < edges.Count; i++)
            {
                Assert.AreEqual(edges[i].From, graph.Edges[i].From);
                Assert.AreEqual(edges[i].To, graph.Edges[i].To);
            }
            Assert.AreEqual(algorithmType, AlgorithmType.TwoApprox);
        }

        [Test]
        public void TestWriteTspResultToFile()
        {
            var edges = new List<Edge>
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
            var graph = new Graph(edges, 9);
            var result = FileProcessing.WriteTspResultToFile(graph, 1000, "testWrite.txt");
            Assert.IsTrue(result);
        }
    }
}
