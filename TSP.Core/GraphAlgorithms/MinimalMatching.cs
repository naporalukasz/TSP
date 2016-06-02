using System.Collections.Generic;
using System.Linq;
using TSP.Core.Model;

namespace TSP.Core.GraphAlgorithms
{
    public class MinimalMatching : IMinimalMatching
    {
        public Graph FindMinimalMatching(Graph kruskalGraph,Graph inputGraph)
        {
            var degreeList = new List<Dictionary<int, int>>();
         
            var verticesCount = new int[5];

            for (int i = 0; i < kruskalGraph.VerticesCount; i++)
                verticesCount[i] = 0;

            foreach (var el in kruskalGraph.Edges)
            {
                verticesCount[el.To]++;
                verticesCount[el.From]++;
            }

            var resultGraph= new List<Edge>();

            for (int i = 0; i < verticesCount.Length; i++)
            {
                if(verticesCount[i]%2==1)
                    resultGraph.AddRange(inputGraph.Edges.Where(x=>x.From==i && verticesCount[x.To] % 2 == 1).Select(s=>s.DeepCopy()));
            }

            //TODO: Stworzenie podgrafu z grafu obecnego i wejściowego

            return new Graph(resultGraph);
        }
    }
}
