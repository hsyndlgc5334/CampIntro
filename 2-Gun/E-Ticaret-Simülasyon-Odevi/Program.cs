using System;

namespace _2_Gun
{
    class Product
    {
        public Product(string name,double price,string description)
        {
            this.Description = description;
            this.Name = name;
            this.Price = price;
        }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Product("Iphone",1212,"iyi telefon");
            var p2 = new Product("Samsung",2212,"müthiş telefon");
            var p3 = new Product("Motorola",3212,"pahalı telefon");
            Product[] products = new Product[]{p1,p2,p3};
            // foreach(var i in products)
            // {
            //     System.Console.WriteLine($"Name:{i.Name} Price:{i.Price} Description:{i.Description}");
            // }
            // int index = 0;
            // while(index<products.Length)
            // {
            //     System.Console.WriteLine($"Name:{products[index].Name} Price:{products[index].Price} Description:{products[index].Description}");
            //     index++;
            // }
            for (int i = 0; i < products.Length; i++)
            {
                System.Console.WriteLine($"Name:{products[i].Name} Price:{products[i].Price} Description:{products[i].Description}");
            }
        }
    }
}
