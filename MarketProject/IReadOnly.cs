using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketProject
{
    internal interface IReadOnly
    {
        void GetAll(List<Product> products);
        void GetById(List<Product> products, int id);
        void GetByCategory(List<Product> products, int categoryId);
    }
}
