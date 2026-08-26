using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment._12
{
    public class Product
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Category { set; get; }//"Electronics","Clothing","Food","Books"
        public double Price { set; get; }
        public int Stock { set; get; }
        public static List<Product> SearchProducts(List<Product>products,Func<Product,bool>Check)
        {
            List<Product> result=new List<Product>();
            foreach (Product product in products)
            {
                if (Check(product))
                { result.Add(product); }
            }
            return result;
        }
        public override string ToString()
        {
            return $"{Name}-${Price}(Stock:{Stock})";
        }
    }
}