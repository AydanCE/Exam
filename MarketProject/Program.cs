
using MarketProject;

List<User> sellers = new List<User>();
List<User> admins = new List<User>();
List<User> chiefCashiers = new List<User>();
List<Product> products = new List<Product>();
List<Product> soldProducts = new List<Product>();
List<Category> categories = new List<Category>();

User admin1 = new() { Id = 1, Name = "Aydan", Surname = "Musayeva", Phone = "1234567", Role = "admin" };
User seller1 = new() { Id = 1, Name = "Ramal", Surname = "Musayev", Phone = "1234567", Role = "seller" };
User chiefCashier1 = new() { Id = 1, Name = "Banu", Surname = "Musayeva", Phone = "1234567", Role = "chiefcashier" };

Category category = new() { Id = 1, CategoryName = "tea and coffee" };
Product product = new() { Id = 1, CategoryId = 1, ProductName = "berqa", Count = 12, Price = 2.5 };
Product product2 = new() { Id = 2, CategoryId = 1, ProductName = "azer cay", Count = 12, Price = 2.5 };
categories.Add(category);

AdminManager adminManager = new AdminManager();
//adminManager.AddProduct(product, products, categories);
//adminManager.AddProduct(product2, products, categories);
//adminManager.RemoveProduct(product, products);
//adminManager.GetAll(products);
//adminManager.AddProduct(product, products, categories);
//adminManager.UpdateProduct(products, "berqa", categories);
//adminManager.GetAll(products);
//adminManager.GetById(products, 2);
//adminManager.GetByCategory(products, 1);
//adminManager.AddSeller(sellers, seller1);
//adminManager.AddCashier(chiefCashiers, chiefCashier1);
//adminManager.AddAdmin(admins, admin1);
//foreach (var admin in admins)
//{
//    Console.WriteLine($"{admin.Name}");
//}

//foreach (var seller in sellers)
//{
//    Console.WriteLine($"{seller.Name}");
//}

//foreach (var chiefCashier in chiefCashiers)
//{
//    Console.WriteLine($"{chiefCashier.Name}");
//}

SellerManager sellerManager = new SellerManager();

//sellerManager.GetAll(products);
//sellerManager.GetByCategory(products, 1);
//sellerManager.GetById(products, 2);
//sellerManager.Selling(soldProducts, product);
//sellerManager.GetAll(products);

ChiefCashierManager chiefCashierManager = new ChiefCashierManager();

chiefCashierManager.AddProduct(product, products, categories);
chiefCashierManager.AddProduct(product2, products, categories);
chiefCashierManager.RemoveProduct(product, products);
chiefCashierManager.GetAll(products);
chiefCashierManager.AddProduct(product, products, categories);
chiefCashierManager.UpdateProduct(products, "azer cay", categories);
chiefCashierManager.GetAll(products);
chiefCashierManager.GetById(products, 2);
chiefCashierManager.GetByCategory(products, 1);
sellerManager.Selling(soldProducts, product);
chiefCashierManager.GetById(products, 1);
chiefCashierManager.ReturnBack(soldProducts, product2);
sellerManager.GetAll(products);
