using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketProject
{
    internal interface IAdminManager
    {
        void AddCashier(List<User> cashiers, User cashier);
        void AddAdmin(List<User> admins, User admin);
        void AddSeller(List<User> sellers, User seller);
    }
}
