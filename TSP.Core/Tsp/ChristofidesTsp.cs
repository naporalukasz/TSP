using TSP.Core.GraphAlgorithms;
using TSP.Core.Model;
using System.Linq;

namespace TSP.Core.Tsp
{
    public class ChristofidesTsp : ITspAlgorithm
    {
        private readonly IKruskalAlgorithm kruskalAlgorithm;
        private readonly IMinimalMatching minimalMatching;
        private readonly IEulerPathFinder eulerPathFinder;
        private readonly IGraphVisitor graphVisitor;

        public ChristofidesTsp(IKruskalAlgorithm kruskalAlgorithm,IMinimalMatching minimalMatching, IEulerPathFinder eulerPathFinder, IGraphVisitor graphVisitor)
        {
            this.kruskalAlgorithm = kruskalAlgorithm;
            this.minimalMatching = minimalMatching;
            this.eulerPathFinder = eulerPathFinder;
            this.graphVisitor = graphVisitor;
        }

        public double Calculate(Graph inputGraph)
        {
            var mst = kruskalAlgorithm.CalculateMst(inputGraph);

            var matching = minimalMatching.FindMinimalMatching(mst, inputGraph);

            var eulerPath = eulerPathFinder.FindPath(matching);
            var tspPath = graphVisitor.Visit(inputGraph, eulerPath);
            var cost = tspPath.Edges.Sum(x => x.Weight);

            return cost;
        }

        public Graph Calculate(Graph inputGraph, out double cost)
        {
            var mst = kruskalAlgorithm.CalculateMst(inputGraph);

            var matching = minimalMatching.FindMinimalMatching(mst, inputGraph);

            var eulerPath = eulerPathFinder.FindPath(matching);
            var tspPath = graphVisitor.Visit(inputGraph, eulerPath);
             cost = tspPath.Edges.Sum(x => x.Weight);
            return tspPath;
        }
    }
}
