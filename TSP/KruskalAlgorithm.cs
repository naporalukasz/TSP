using System.Collections.Generic;
using System.Linq;
using System;


namespace TSP
{
    public class KruskalAlgorithm : IKruskalAlgorithm
    {
        public Graph CalculateMst(Graph graph)
        {
            
            var span = 0.0;
            int[] sets = new int[graph.Edges.Count];
            List<Edge> Result = new List<Edge>();
            int processedEdges = 0;
            foreach (var edge in graph.Edges)
            {

                if (processedEdges == graph.Edges.Count - 1)
                    break;

                if (sets[edge.From] == 0 || sets[edge.From] != sets[edge.To])
                {
                    Result.Add(edge);
                    span += edge.Weight;
                    processedEdges++;

                    if (sets[edge.From] != 0 || sets[edge.To] != 0)
                    {
                     
                        int set1 = sets[edge.From];
                        int set2 = sets[edge.To];
                        for (int i = 0; i < graph.Edges.Count; i++)
                            if (sets[i] != 0 && (sets[i] == set1 || sets[i] == set2))
                                sets[i] = processedEdges;
                    }

                    sets[edge.From] = processedEdges;
                    sets[edge.To] = processedEdges;
                }
            }
     
            return new Graph(Result);
        }
    }

  
}