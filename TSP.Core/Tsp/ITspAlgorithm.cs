using TSP.Core.Model;

namespace TSP.Core.Tsp
{
    public interface ITspAlgorithm
    {
        Graph Calculate(Graph inputGraph, out double cost);
    }
}