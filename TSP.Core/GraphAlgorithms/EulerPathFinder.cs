using System.Collections.Generic;
using System.Linq;
using TSP.Core.Model;

namespace TSP.Core.GraphAlgorithms
{
    public class EulerPathFinder : IEulerPathFinder
    {
        private readonly List<Edge> result = new List<Edge>();
        private List<Edge> tmpEdgeList = new List<Edge>();
        private readonly List<int> path = new List<int>();

        public Graph FindPath(Graph graph)
        {
            tmpEdgeList = graph.Edges.Select(s => s.DeepCopy()).ToList();
            Find(0);
            var list = path.ToList();
            for (var i = 0; i < list.Count - 1; i++)
            {
                var edge = graph.Edges.Find(e => e.From == list[i] && e.To == list[i + 1]);
                if (edge != null)
                    result.Add(edge);
                else
                {
                    edge = graph.Edges.Find(e => e.From == list[i + 1] && e.To == list[i]);
                    result.Add(edge);
                }
            }
            return new Graph(result);
        }

        private void Find(int v)
        {
            var stack = new Stack<int>();
            while (stack.Any() || tmpEdgeList.Any(e => e.From == v || e.To == v))
            {
                var neighbors = tmpEdgeList.Where(e => e.From == v || e.To == v).ToList();
                if (!neighbors.Any())
                {
                    path.Add(v);
                    var last = stack.Peek();
                    stack.Pop();
                    v = last;
                }
                else
                {
                    stack.Push(v);
                    var neighbor = neighbors.Last();
                    tmpEdgeList.Remove(neighbors.Last());
                    v = v == neighbor.To ? neighbor.From : neighbor.To;
                }
            }
            path.Add(v);
        }
    }
}