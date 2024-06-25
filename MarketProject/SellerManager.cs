using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketProject
{
    internal class SellerManager : IReadOnly, ISellerManager
    {
        public void GetAll(List<Product> products)
        {
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"Product Name: {products[i].ProductName} Price: {products[i].Price} Count: {products[i].Count} CategoryId: {products[i].CategoryId}");
            }
        }

        public void GetByCategory(List<Product> products, int categoryId)
        {
            foreach (Product product in products)
            {
                if (product.CategoryId == categoryId)
                {
                    Console.WriteLine($"Product Name: {product.ProductName} Price: {product.Price} Count: {product.Count}");
                }
            }
        }

        public void GetById(List<Product> products, int id)
        {
            foreach (Product product in products)
            {
                if (product.Id == id)
                {
                    Console.WriteLine($"Product Name: {product.ProductName}  Price:  {product.Price} Count: {product.Count}");
                }
            }
        }
        public void Selling(List<Product> soldProducts, Product product)
        {
            product.Count--;
            if (product.Count < 0) Console.WriteLine("There is no adequate product for selling");
            else
            {
                Console.WriteLine($"{product.ProductName} has been successfully sold");
                soldProducts.Add(product);
            }
        }
    }
}
