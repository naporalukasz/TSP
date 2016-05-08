using System.Collections.Generic;

namespace TSP
{
    public class EdgeComparer : IComparer<Edge>
    {
        public int Compare(Edge x, Edge y)
        {
            if (x.Weight < y.Weight)
                return 1;
            if (x.Weight == y.Weight)
                return 0;
            return -1;
        }
    }
}