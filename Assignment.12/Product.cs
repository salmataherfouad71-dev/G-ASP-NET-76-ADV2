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
        //Func delegate type because there is one Product input and bool return type(can use Predicate too).
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
        //Action because the input is Product and no return type (void).
        public static void PrintReport(List<Product>products,Action<Product> printer)
        {
            foreach (Product product in products)
            {
                printer(product);
            }
        }
        //Func delegate type because there is one Pronduct input and the return type is string.
        public static List<string> TransformProducts(List<Product> products,Func<Product,string> transform)
        {
            List<string> result = new List<string>();
            foreach (Product product in products)
            {
                result.Add(transform(product));
            }
            return result;
        }
        //Predicate delegate type because there is one Product input and a bool return type. 
        public static List<Product> FilterProducts(List<Product> products, Predicate<Product> filter)
        { 
            List<Product>result=new List<Product>();
            foreach (Product product in products)
            {
                if (filter(product))
                {
                    result.Add(product);
                }
            }
            return result;
        }
    }
}