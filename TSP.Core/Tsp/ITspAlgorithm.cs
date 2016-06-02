using TSP.Core.Model;

namespace TSP.Core.Tsp
{
    public interface ITspAlgorithm
    {
        double Calculate(Graph inputGraph);
    }
}