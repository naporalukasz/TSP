using System.Collections.Generic;
using System.Linq;
using TSP.Core.Model;

namespace TSP.Core.GraphAlgorithms
{
    public class GraphVisitor : IGraphVisitor
    {
        public Graph Visit(Graph originalGraph, Graph eulerGraph)
        {
            var hamiltionianCycleGraph = new Graph { Edges = new List<Edge>() };
            var verticesSet = new HashSet<int> { eulerGraph.Edges.First().From };
            foreach (var edge in eulerGraph.Edges)
            {
                if (!verticesSet.Contains(edge.To))
                    verticesSet.Add(edge.To);
            }
            var verticesList = verticesSet.ToList();
            for (var i = 0; i < verticesList.Count - 1; i++)
            {
                var edge = originalGraph.Edges.Find(e => e.From == verticesList[i] && e.To == verticesList[i + 1]) ??
                           originalGraph.Edges.Find(e => e.To == verticesList[i] && e.From == verticesList[i + 1]);
                hamiltionianCycleGraph.Edges.Add(edge.DeepCopy());
            }

            var lastEdge = originalGraph.Edges.Find(e => e.From == verticesList.First() && e.To == verticesList.Last()) ??
                           originalGraph.Edges.Find(e => e.To == verticesList.First() && e.From == verticesList.Last());
            hamiltionianCycleGraph.Edges.Add(lastEdge.DeepCopy());

            hamiltionianCycleGraph.VerticesCount = originalGraph.VerticesCount;
            return hamiltionianCycleGraph;
        }
    }
}