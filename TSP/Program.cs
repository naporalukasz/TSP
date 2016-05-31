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

            var tmp = new Graph(list);
            var Kruskal = new KruskalAlgorithm();
            var Euler = new EulerPathFinder();
            var result = Kruskal.CalculateMst(tmp);

            var duplicatedEdgesList = new List<Edge>();
            foreach (var edge in result.Edges)
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
