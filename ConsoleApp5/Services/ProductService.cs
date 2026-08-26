using ConsoleApp5.Interfaces;
using ConsoleApp5.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5.Services
{
    public class ProductService : IServices
    {
        private List<Product> products;
        private Random rnd;

        public ProductService()
        {
            products = new List<Product>();
            rnd = new Random();
        }

        // Create
        public void Create(Product product)
        {
            products.Add(product);
        }

        // Delete
        public void Delete(int id)
        {
            Product p = Search(id);

            if (p != null)
            {
                products.Remove(p);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }

        // Mock ข้อมูลจำนวน n ชุด
        public void Mock(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Product p = new Product()
                {
                    Id = i,
                    Name = "Product" + i,
                    Price = rnd.Next(100, 1001)
                };

                products.Add(p);
            }
        }

        // Read
        public void Read()
        {
            foreach (Product p in products)
            {
                p.Display();
            }
        }

        // Search
        public Product Search(int id)
        {
            return products.Find(p => p.Id == id);
        }

        // Update
        public void Update(int id)
        {
            Product p = Search(id);

            if (p != null)
            {
                Console.Write("New Name : ");
                p.Name = Console.ReadLine();

                Console.Write("New Price : ");
                p.Price = Convert.ToDouble(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }
}
