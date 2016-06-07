using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using TSP.Core.Model;

namespace TSP.Core.GraphAlgorithms
{
    public class MinimalMatching : IMinimalMatching
    {
        public Graph FindMinimalMatching(Graph kruskalGraph, Graph inputGraph)
        {          
            var verticesCount = new int[kruskalGraph.VerticesCount];

            for (var i = 0; i < kruskalGraph.VerticesCount; i++)
                verticesCount[i] = 0;

            foreach (var el in kruskalGraph.Edges)
            {
                verticesCount[el.To]++;
                verticesCount[el.From]++;
            }

            var resultGraph= new List<Edge>();

            for (var i = 0; i < verticesCount.Length; i++)
            {
                if(verticesCount[i]%2==1)
                    resultGraph.AddRange(inputGraph.Edges.Where(x=>x.From==i && verticesCount[x.To] % 2 == 1).Select(s=>s.DeepCopy()));
            }

            var newGraph=new List<Edge>();
            var clone = new Graph(resultGraph);
            foreach (var deleteEdge in kruskalGraph.Edges)
            {
                clone.Edges.RemoveAll(x => x.To == deleteEdge.To && x.From == deleteEdge.From);
            }
           
            var odds = new List<int>();
            foreach (var edge in resultGraph)
            {
                if(!odds.Contains(edge.From))
                    odds.Add(edge.From);
                if (!odds.Contains(edge.To))
                    odds.Add(edge.To);
            }

            while (odds.Any() )
            {
                double length = int.MaxValue;
                Edge edgeToAdd= null;
                foreach (var edge in clone.Edges.Where(x => odds.Contains(x.To) && odds.Contains(x.From)))
                {
                    if (edge.Weight < length)
                    {
                        length = edge.Weight;
                        edgeToAdd = edge;
                    }
                }  
              
                if (edgeToAdd != null)
                {
                    newGraph.Add(edgeToAdd);
                    odds.Remove(edgeToAdd.From);
                    odds.Remove(edgeToAdd.To);
                }

            }
            var tpm3 = kruskalGraph.Edges;
            tpm3.AddRange(newGraph);
            var returnGraph=  new Graph(tpm3);
            
            return returnGraph;
        }
    }
}
