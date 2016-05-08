namespace TSP
{
    public class GraphVisitor : IGraphVisitor
    {
        public Graph Visit(Graph graph)
        {
            return new Graph();
        }
    }
}