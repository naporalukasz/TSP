using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP
{
    public class Graph
    {
        public SortedSet<Edge> Edges { get; set; }

        public Graph(int[] vertices, int[] neighboursCount)
        {
        }

        public Graph()
        {
        }
    }
}
