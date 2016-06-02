using System.Collections.Generic;
using System.Linq;
using TSP.Core.GraphAlgorithms;
using TSP.Core.Model;

namespace TSP.Core.Tsp
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
                duplicatedEdgesList.Add(edge.DeepCopy());
                duplicatedEdgesList.Add(new Edge { To = edge.From, From = edge.To, Weight = edge.Weight });
            }
            var duplicatedEdgesGraph = new Graph { Edges = new List<Edge>(duplicatedEdgesList) };
            var eulerPath = eulerPathFinder.FindPath(duplicatedEdgesGraph);
            var tspPath = graphVisitor.Visit(eulerPath);
            var weightSum = tspPath.Edges.Sum(x => x.Weight);
            return weightSum;
        }

    }
}