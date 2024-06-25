using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketProject
{
    internal class ChiefCashierManager : ProductManager, IChiefCashierManager
    {
        private bool IsProductSold(List<Product> soldProducts, Product product)
        {
            foreach (Product prod in soldProducts)
            {
                if (prod == product) return true;
            }
            return false;
        }
        public void ReturnBack(List<Product> soldProducts, Product product)
        {
            if (soldProducts.Count > 0 && IsProductSold(soldProducts, product))
            {
                soldProducts.Remove(product);
                product.Count++;
                Console.WriteLine($"{product.ProductName} has been successfully come back");
            }
            else Console.WriteLine($"{product.ProductName} has not been sold");
        }
    }
}
