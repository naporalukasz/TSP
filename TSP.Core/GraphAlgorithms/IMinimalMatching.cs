using TSP.Core.Model;

namespace TSP.Core.GraphAlgorithms
{
    public interface IMinimalMatching
    {
        Graph FindMinimalMatching(Graph graph, Graph inputGraph);
    }
}
