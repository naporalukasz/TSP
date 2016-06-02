using System.Collections.Generic;
using System.Linq;
using TSP.Core.Model;

namespace TSP.Core.GraphAlgorithms
{
    public class EulerPathFinder : IEulerPathFinder
    {
        private readonly List<Edge> result = new List<Edge>();
        private List<Edge> tmpEdgeList = new List<Edge>();

        public Graph FindPath(Graph graph)
        {
            tmpEdgeList = graph.Edges.Select(s => s.DeepCopy()).ToList();
            Find(0);
            return new Graph(result);
        }

        private void Find(int v)
        {
            var currentEdges = new Stack<Edge>(tmpEdgeList.Where(w => w.From == v).Select(s => s.DeepCopy()).ToList());
            while (currentEdges.Count != 0)
            {
                var edge = currentEdges.Pop();
                tmpEdgeList.Remove(tmpEdgeList.Find(e => e.From == edge.From && e.To == edge.To));
                tmpEdgeList.Remove(tmpEdgeList.Find(e => e.To == edge.From && e.From == edge.To));
                Find(edge.To);
                result.Add(edge);
            }
        }
    }
}