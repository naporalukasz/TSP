namespace TSP
{
    public class Edge
    {
        public int From { get; set; }
        public int To { get; set; }
        public double Weight { get; set; }

        public Edge() { }

        public Edge(int From, int To, double Weight)
        {
            this.From = From;
            this.To = To;
            this.Weight = Weight;
        }

        public Edge DeepCopy()
        {
            return new Edge
            {
                From = this.From,
                To = this.To,
                Weight = this.Weight,
                
            };
        }

    }
}