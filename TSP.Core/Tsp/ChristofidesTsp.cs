using TSP.Core.GraphAlgorithms;
using TSP.Core.Model;

namespace TSP.Core.Tsp
{
    public class ChristofidesTsp : ITspAlgorithm
    {
        private readonly IKruskalAlgorithm kruskalAlgorithm;
        private readonly IMinimalMatching minimalMatching;
        //private readonly IEulerPathFinder eulerPathFinder;
        //private readonly IGraphVisitor graphVisitor;

        public ChristofidesTsp(IKruskalAlgorithm kruskalAlgorithm,IMinimalMatching minimalMatching)
        {
            this.kruskalAlgorithm = kruskalAlgorithm;
            this.minimalMatching = minimalMatching;
            //this.eulerPathFinder = eulerPathFinder;
            //this.graphVisitor = graphVisitor;
        }

        public double Calculate(Graph inputGraph)
        {
            var mst = kruskalAlgorithm.CalculateMst(inputGraph);

            var matching = minimalMatching.FindMinimalMatching(mst, inputGraph);


           
            return 0;
        }
    }
}
