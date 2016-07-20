namespace DomainModel
{
    public struct Product
    {
        public string Name { get; set; }

        public double Cost { get; set; }

        public int Count { get; set; }

        public override string ToString()
        {
            return $"Name: {this.Name}, Cost: {this.Cost}, Available: {this.Count}";
        }
    }
}