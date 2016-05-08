namespace TSP
{
    public interface IGraphVisitor
    {
        Graph Visit(Graph graph);
    }
}