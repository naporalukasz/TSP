using TSP.Core.Model;

namespace TSP.Core.GraphAlgorithms
{
    public interface IEulerPathFinder
    {
        Graph FindPath(Graph graph);
    }
}