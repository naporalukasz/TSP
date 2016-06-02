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
            var list2 = new List<Edge>()
            {
                new Edge { From=0,To=2,Weight=1 },
                new Edge { From=1,To=2,Weight=1 },
                new Edge { From=2,To=4,Weight=1 },
                new Edge { From=2,To=3,Weight=1 },
                new Edge { From=0,To=1,Weight=1 },
                new Edge { From=0,To=3,Weight=2 },
                new Edge { From=0,To=4,Weight=1 },
                new Edge { From=1,To=3,Weight=1 },
                new Edge { From=1,To=4,Weight=2 },
                new Edge { From=2,To=3,Weight=1 },
                new Edge { From=3,To=4,Weight=1 },
            };
            var kruskalAlgorithm = new KruskalAlgorithm();
            var euler = new EulerPathFinder();

            var graph = new Graph(list2, 5);
            var kruskalResult = kruskalAlgorithm.CalculateMst(graph);
            var duplicatedEdgesList = new List<Edge>();
            foreach (var edge in kruskalResult.Edges)
            {
                duplicatedEdgesList.Add(edge.DeepCopy());
                duplicatedEdgesList.Add(new Edge { To = edge.From, From = edge.To, Weight = edge.Weight });
            }
            var duplicatedEdgesGraph = new Graph { Edges = new List<Edge>(duplicatedEdgesList) };
            var eulerPath = euler.FindPath(duplicatedEdgesGraph);
        }
    }
}
