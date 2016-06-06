using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSP.Core.Model;

namespace TSP.Core.Helpers
{
    public static class GraphFactory
    {
        public static Graph CreateCompleteGraph(int verticesCount, double[,] weightMatrix)
        {
            var graph = new Graph(new List<Edge>(), verticesCount);
            for (var i = 0; i < verticesCount; i++)
            {
                for (var j = i + 1; j < verticesCount; j++)
                {
                    graph.Edges.Add(new Edge(i, j, weightMatrix[i, j]));
                }
            }
            return graph;
        }
    }
}
