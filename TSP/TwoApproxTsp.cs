using System.Collections.Generic;
using System.Linq;

namespace TSP
{
    public class TwoApproxTsp : ITspAlgorithm
    {
        private readonly IKruskalAlgorithm kruskalAlgorithm;
        private readonly IEulerPathFinder eulerPathFinder;
        private readonly IGraphVisitor graphVisitor;

        public TwoApproxTsp(IKruskalAlgorithm kruskalAlgorithm, IEulerPathFinder eulerPathFinder, IGraphVisitor graphVisitor)
        {
            this.kruskalAlgorithm = kruskalAlgorithm;
            this.eulerPathFinder = eulerPathFinder;
            this.graphVisitor = graphVisitor;
        }

        public double Calculate(Graph inputGraph)
        {
            var mst = kruskalAlgorithm.CalculateMst(inputGraph);
            var duplicatedEdgesList = new List<Edge>();
            foreach (var edge in mst.Edges)
            {
                duplicatedEdgesList.Add(edge);
                duplicatedEdgesList.Add(edge);
            }
            var duplicatedEdgesGraph = new Graph {Edges = new List<Edge>(duplicatedEdgesList)};
            var eulerPath = eulerPathFinder.FindPath(duplicatedEdgesGraph);
            var tspPath = graphVisitor.Visit(eulerPath);
            var weightSum = tspPath.Edges.Sum(x => x.Weight);
            return weightSum;
        }

    }
}