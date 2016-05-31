using System.Collections.Generic;
using System.Linq;
using System;

namespace TSP
{
    public class EulerPathFinder : IEulerPathFinder
    {
        List<Edge> wynik = new List<Edge>();
        List<Edge> tmpEdgeList = new List<Edge>();

        public Graph FindPath(Graph graph)
        {
            var EdgeList = graph.Edges;
            tmpEdgeList = graph.Edges.Select(s => s.DeepCopy()).ToList();
            Find(0);
            return new Graph(wynik);
        }

        public void Find(int v)
        {
            var currEdge = tmpEdgeList.Where(w=>w.From==v).Select(s => s.DeepCopy()).ToList();
            while (currEdge.Count != 0)
            {
                var w = currEdge[0];
                tmpEdgeList.Remove(w);
                currEdge.Remove(w);
                Find(w.To);
                wynik.Add(w);               
            }

        }
    }
}