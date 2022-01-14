using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{C_id=1,CategoryName="PC"},
                new Category{C_id=2,CategoryName="Phone"}
            };
            List<Product> products = new List<Product>
            {
                new Product{Id=1,C_id=1,Name="ASUS",Price=10000,Stock=10},
                new Product{Id=2,C_id=1,Name="Casper",Price=8000,Stock=5},
                new Product{Id=3,C_id=1,Name="HP",Price=12000,Stock=4},
                new Product{Id=4,C_id=2,Name="Samsung",Price=5000,Stock=15},
                new Product{Id=5,C_id=2,Name="Apple",Price=15000,Stock=12},
            };
            
            foreach (var product in GetProducts(products))
            {
                Console.WriteLine(product.Name);
            }
            
            Console.ReadLine();
        }
        static List<Product> GetProducts(List<Product> products)
        {
            return products.Where(p => p.Price > 8000 && p.Stock > 5).ToList();
        }
    }
    class Category
    {
        public int C_id { get; set; }

        public string CategoryName { get; set; }
    }
    class Product
    {
        public int Id { get; set; }

        public int C_id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public int Stock { get; set; }
    }
}
