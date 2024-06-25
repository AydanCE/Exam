using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketProject
{
    internal interface IProductManager : IReadOnly
    {
        void AddProduct(Product product, List<Product> products, List<Category> categories);
        void RemoveProduct(Product product, List<Product> products);
        void UpdateProduct(List<Product> products, string productName, List<Category> categories);
    }
}
