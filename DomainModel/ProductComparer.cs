using System.Collections.Generic;

namespace DomainModel
{
    public class ProductComparer : IEqualityComparer<Product>
    {
        public bool Equals(Product x, Product y)
        {
            return string.Equals(x.Name, y.Name);
        }

        public int GetHashCode(Product obj)
        {
            return obj.Name.GetHashCode();
        }
    }
}