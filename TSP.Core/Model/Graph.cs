using System.Collections.Generic;

namespace TSP.Core.Model
{
    public class Graph
    {
        public List<Edge> Edges { get; set; }
        public int VerticesCount { get; set; }

        public Graph(List<Edge> edge)
        {
            Edges = edge;
        }

        public Graph(List<Edge> edge, int verticesCount)
        {
            Edges = edge;
            VerticesCount = verticesCount;
        }

        public Graph(int[] vertices, int[] neighboursCount)
        {
        }

        public Graph()
        {
        }
    }
}
