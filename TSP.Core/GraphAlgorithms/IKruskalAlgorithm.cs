using TSP.Core.Model;

namespace TSP.Core.GraphAlgorithms
{
    public interface IKruskalAlgorithm
    {
        Graph CalculateMst(Graph graph);
    }
}