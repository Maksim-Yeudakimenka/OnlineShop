using System.Collections.Generic;
using System.Linq;
using DomainModel;

namespace TestApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var first = new List<Product>
            {
                new Product { Name = "Chess", Cost = 75.00, Count = 10 },
                new Product { Name = "Soccer Ball", Cost = 19.50, Count = 9 },
                new Product { Name = "Table", Cost = 215.00, Count = 8 },
                new Product { Name = "Chair", Cost = 25.50, Count = 40 }
            };

            var second = new List<Product>
            {
                new Product { Name = "Soccer Ball", Cost = 19.50, Count = 5 },
                new Product { Name = "Table", Cost = 215.00, Count = 3 },
                new Product { Name = "Playing Cards Deck", Cost = 5.00, Count = 11 }
            };

            var comparer = new ProductComparer();

            var intersection = first.Intersect(second, comparer).ToList();
            var union = first.Union(second, comparer).ToList();
            var difference = first.Except(second, comparer).ToList();
        }
    }
}