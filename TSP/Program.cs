using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP
{
    class Program
    {
        static void Main(string[] args)
        {

            var list = new List<Edge>()
            {
                new Edge(){ From=0,To=1,Weight=0.1 },
                new Edge(){ From=0,To=2,Weight=0.1 },
                new Edge(){ From=0,To=3,Weight=0.1 },
                new Edge(){ From=1,To=2,Weight=0.3 },
                new Edge(){ From=1,To=3,Weight=0.3 },
                new Edge(){ From=2,To=3,Weight=0.3 }
            };

            var list2 = new List<Edge>()
            {
                new Edge(){ From=0,To=2,Weight=1 },
                new Edge(){ From=0,To=3,Weight=2 },
                new Edge(){ From=1,To=2,Weight=1 },
                new Edge(){ From=1,To=4,Weight=2 },
                new Edge(){ From=2,To=3,Weight=1 },
                new Edge(){ From=2,To=4,Weight=1 }
            };

            var tmp = new Graph(list2,5);
            var Kruskal = new KruskalAlgorithm();
            var Euler = new EulerPathFinder();
            var MinimalMatching = new MinimalMatching();
            var kruskal = Kruskal.CalculateMst(tmp);

            var minimal = MinimalMatching.FindMinimalMatching(kruskal);

            var duplicatedEdgesList = new List<Edge>();
            foreach (var edge in kruskal.Edges)
            {
                duplicatedEdgesList.Add(edge);
                duplicatedEdgesList.Add(new Edge() { To = edge.From, From = edge.To, Weight = edge.Weight});
            }
            var duplicatedEdgesGraph = new Graph { Edges = new List<Edge>(duplicatedEdgesList) };
            var eulerPath = Euler.FindPath(duplicatedEdgesGraph);

            var a = 1;

        }
    }
}
