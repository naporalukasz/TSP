using System.Collections.Generic;
using System.Linq;
using TSP.Core.Model;

namespace TSP.Core.GraphAlgorithms
{
    public class KruskalAlgorithm : IKruskalAlgorithm
    {
        public Graph CalculateMst(Graph graph)
        {
            var span = 0.0;
            var sets = new int[graph.Edges.Count];
            var result = new List<Edge>();
            var processedEdges = 0;
            foreach (var edge in graph.Edges.OrderBy(o => o.Weight))
            {

                if (processedEdges == graph.Edges.Count - 1)
                    break;

                if (sets[edge.From] == 0 || sets[edge.From] != sets[edge.To])
                {
                    result.Add(edge);
                    span += edge.Weight;
                    processedEdges++;

                    if (sets[edge.From] != 0 || sets[edge.To] != 0)
                    {
                        var set1 = sets[edge.From];
                        var set2 = sets[edge.To];
                        for (var i = 0; i < graph.Edges.Count; i++)
                            if (sets[i] != 0 && (sets[i] == set1 || sets[i] == set2))
                                sets[i] = processedEdges;
                    }

                    sets[edge.From] = processedEdges;
                    sets[edge.To] = processedEdges;
                }
            }
            return new Graph(result);
        }
    }


}