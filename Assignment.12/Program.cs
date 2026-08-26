using System.Collections;

namespace Assignment._12
{
    public class Program
    {
        public static void Print(List<Product> products)
        {
            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }
        }
        static void Main(string[] args)
        {
            #region SmartProductSearch
            List<Product> Catalog = new()
            {
                new Product{Id=1,Name="Laptop",Category="Electronics",Price=1200,Stock=10},
                new Product{Id=2,Name="Phone",Category="Electronics",Price=800,Stock=25},
                new Product{Id=3,Name="T-Shirt",Category="Clothing",Price=30,Stock=100},
                new Product{Id=4,Name="Jeans",Category="Clothing",Price=60,Stock=50},
                new Product{Id=5,Name="Chocolate",Category="Food",Price=5,Stock=200},
                new Product{Id=6,Name="Coffee Beans",Category="Food",Price=15,Stock=80},
                new Product{Id=7,Name="C# Book",Category="Books",Price=45,Stock=30},
                new Product{Id=8,Name="Novel",Category="Books",Price=20,Stock=60},
                new Product{Id=9,Name="Headphones",Category="Electronics",Price=150,Stock=40},
                new Product{Id=10,Name="Jacket",Category="Clothing",Price=120,Stock=15},
            };
            Console.WriteLine("---Electronics---");
            Print(Product.SearchProducts(Catalog, (Product p) => p.Category == "Electronics"));
            Console.WriteLine();
            Console.WriteLine("---Under $50---");
            Print(Product.SearchProducts(Catalog, (Product p) => p.Price <50));
            Console.WriteLine();
            Console.WriteLine("---In Stock---");
            Print(Product.SearchProducts(Catalog, (Product p) => p.Stock > 0));
            Console.WriteLine();
            Console.WriteLine("---Clothing Under $100---");
            Print(Product.SearchProducts(Catalog, (Product p) => p.Category == "Clothing"&& p.Price<100));
            Console.WriteLine();
            #endregion
            #region PrintReports
            Console.WriteLine("---Short Report---");
            Product.PrintReport(Catalog, (Product p) => Console.WriteLine($"{p.Name}-${p.Price}"));
            Console.WriteLine();
            Console.WriteLine("---Detailed Report---");
            Product.PrintReport(Catalog, (Product p) => Console.WriteLine($"[{p.Category}] {p.Name} | Price:{p.Price} | Stock:{p.Stock}"));
            Console.WriteLine();
            #endregion
        }
    }
}
