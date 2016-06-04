using TSP.Core.Model;

namespace TSP.Core.GraphAlgorithms
{
    public interface IGraphVisitor
    {
        Graph Visit(Graph originalGraph, Graph eulerGraph);
    }
}