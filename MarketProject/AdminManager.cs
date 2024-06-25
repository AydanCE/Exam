using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketProject
{
    internal class AdminManager : ProductManager, IAdminManager
    {
        public void AddCashier(List<User> cashiers, User cashier)
        {
            cashiers.Add(cashier);
            Console.WriteLine($"Cashier {cashier.Name} has been successfully added.");
        }
        public void AddAdmin(List<User> admins, User admin)
        {
            admins.Add(admin);
            Console.WriteLine($"Admin {admin.Name} has been successfully added.");
        }
        public void AddSeller(List<User> sellers, User seller)
        {
            sellers.Add(seller);
            Console.WriteLine($"Seller {seller.Name} has been successfully added.");
        }
    }
}
