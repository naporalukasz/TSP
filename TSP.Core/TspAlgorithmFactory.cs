using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSP.Core.GraphAlgorithms;
using TSP.Core.Tsp;

namespace TSP.Core
{
    public enum AlgorithmType
    {
        TwoApprox,
        Christofides
    }
    public class TspAlgorithmFactory
    {
        public static ITspAlgorithm CreateAlgorithm(AlgorithmType algorithmType)
        {
            var kruskalAlgorithm = new KruskalAlgorithm();
            var eulerAlgorithm = new EulerPathFinder();
            var graphVisitor = new GraphVisitor();
            var minimal = new MinimalMatching();
            switch (algorithmType)
            {
                case AlgorithmType.TwoApprox:
                    return new TwoApproxTsp(kruskalAlgorithm, eulerAlgorithm, graphVisitor);
                case AlgorithmType.Christofides:
                    return new ChristofidesTsp(kruskalAlgorithm, minimal, eulerAlgorithm, graphVisitor);
                default:
                    throw new ArgumentOutOfRangeException(nameof(algorithmType), algorithmType, null);
            }
        }
    }
}
