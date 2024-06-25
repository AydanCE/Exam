using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketProject
{
    internal interface ISellerManager
    {
        void Selling(List<Product> soldProducts, Product product);
    }
}
