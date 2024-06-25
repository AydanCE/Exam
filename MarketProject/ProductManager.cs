using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketProject
{
    internal abstract class ProductManager : IProductManager
    {
        private bool IsCategoryExist(int id, List<Category> categories)
        {
            for (int i = 0; i < categories.Count; i++)
            {
                if (categories[i].Id == id) return true;
            }
            return false;
        }
        public void AddProduct(Product product, List<Product> products, List<Category> categories)
        {
            if (!(IsCategoryExist(product.CategoryId, categories))) Console.WriteLine($"There is no such a category for {product.ProductName}");
            else
            {
                products.Add(product);
                Console.WriteLine($"{product.ProductName} has been successfully added");
            }
        }

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

        public void RemoveProduct(Product product, List<Product> products)
        {
            products.Remove(product);
            Console.WriteLine($"{product.ProductName} has been succesfully deleted");
        }
        public void UpdateProduct(List<Product> products, string productName, List<Category> categories)
        {
            foreach (Product product in products)
            {
                if (product.ProductName == productName)
                {
                    Console.WriteLine("Enter new Product Name (If you do not want update the field just press space)");
                    string tempName = Console.ReadLine();
                    if (tempName != "") product.ProductName = tempName;
                    Console.WriteLine("Enter new Product Price");
                    string tempPrice = Console.ReadLine();
                    if (tempPrice != "") product.Price = Convert.ToDouble(tempPrice);
                    Console.WriteLine("Enter new Count");
                    string tempCount = Console.ReadLine();
                    if (tempCount != "") product.Count = Convert.ToInt32(tempCount);
                    Console.WriteLine("Enter new Category Id");
                    string tempCatId = Console.ReadLine();
                    if (tempCatId != "")
                    {
                        int temp = Convert.ToInt32(tempCatId);
                        if (IsCategoryExist(temp, categories)) product.CategoryId = temp;
                        else Console.WriteLine("There is no such a category");
                    }
                }
            }
        }
    }
}
