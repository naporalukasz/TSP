using System.Collections.Generic;
using System.Linq;
using TSP.Core.Model;

namespace TSP.Core.GraphAlgorithms
{
    public class EulerPathFinder : IEulerPathFinder
    {
        private readonly List<Edge> result = new List<Edge>();
        private List<Edge> tmpEdgeList = new List<Edge>();
        private List<int> ints = new List<int>();

        public Graph FindPath(Graph graph)
        {
            tmpEdgeList = graph.Edges.Select(s => s.DeepCopy()).ToList();
            Find(0);
            return new Graph(result);
        }

        private void Find(int v)
        {
            var forward = new Stack<Edge>();
            var backtrack = new Stack<Edge>();
            var edge = tmpEdgeList.Where(w => w.From == v).Select(s => s.DeepCopy()).FirstOrDefault();
            while (edge != null)
            {
                tmpEdgeList.Remove(tmpEdgeList.Find(e => e.From == edge.From && e.To == edge.To));
                forward.Push(edge);
                edge = tmpEdgeList.Where(w => w.From == edge.To).Select(s => s.DeepCopy()).FirstOrDefault();
            }


            while (forward.Count != 0)
            {
                edge = forward.Pop();
                backtrack.Push(edge);
                edge = tmpEdgeList.Where(w => w.From == edge.From).Select(s => s.DeepCopy()).FirstOrDefault();
                while (edge != null)
                {
                    tmpEdgeList.Remove(tmpEdgeList.Find(e => e.From == edge.From && e.To == edge.To));
                    forward.Push(edge);
                    edge = tmpEdgeList.Where(w => w.From == edge.To).Select(s => s.DeepCopy()).FirstOrDefault();
                }
            }

            while (backtrack.Count != 0)
            {
                edge = backtrack.Pop();
                result.Add(edge);
            }
        }
    }
}