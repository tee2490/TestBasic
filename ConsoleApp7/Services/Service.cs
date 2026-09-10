using ConsoleApp7.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7.Services
{
    public class Service : IService
    {

        List<Product> Products;
        Random rnd;

        public Service()
        {
            Products = new List<Product>();
            rnd = new Random();
        }

        public void Display()
        {
            Console.WriteLine($"{"ID",6} {"Prod.",12} {"Price",8} " +
                $"{"M1",5} {"M2",5} {"M3",5} {"M4",5}" +
                $"{"Total",7} {"Sales",12}");

            Console.WriteLine(new string('-', 70));


            foreach (var p in Products)
            {
                Console.WriteLine(
                    $"{p.Id,6} {p.Name,12} {p.Price,8:N2}" +
                    $"{p.M1,5} {p.M2,5} {p.M3,5} {p.M4,5}" +
                    $"{p.TotalQuantity(),7} {p.Amount(),12:N2}"
                );
            }

            int sumM1 = Products.Sum(p => p.M1);
            int sumM2 = Products.Sum(p => p.M2);
            int sumM3 = Products.Sum(p => p.M3);
            int sumM4 = Products.Sum(p => p.M4);


            int totalQuantity = Products.Sum(p => p.TotalQuantity());

            double totalSales = Products.Sum(p => p.Amount());

            Console.WriteLine(
                $"{"TOTAL",6} {"",12} {"",8}" +
                $"{sumM1,5} {sumM2,5} {sumM3,5} {sumM4,5}" +
                $"{totalQuantity,7} {totalSales,12:N2}"
            );

            var maxQty = Products.Max(p=>p.TotalQuantity());

            var bestProducts = Products.Where(p => p.TotalQuantity().Equals(maxQty)).ToList();

            Console.Write($"Best Product ({maxQty}) : ");

            foreach (var p in bestProducts)
            {
                Console.Write($"{p.Name} ");
            }

            Console.WriteLine();


            int[] months ={sumM1, sumM2, sumM3, sumM4 };

            int maxMonth = months.Max();


            Console.Write($"Best Month ({maxMonth}) : ");

            for (int i = 0; i < months.Length; i++)
            {
                if (months[i] == maxMonth)
                    Console.Write($"M{i + 1} ");
            }

            Console.WriteLine($"Total Quantity = {totalQuantity:N0}");
            Console.WriteLine($"Total Sales    = {totalSales:N2}");

            double averageSales = totalSales / 4;

            Console.WriteLine($"Average Sales  = {averageSales:N2}");

        }

        public void Mock(int number = 10)
        {
            for (int i = 1; i <= number; i++)
            {
                Product p = new Product()
                {
                    Id = "P" + i.ToString("000"),
                    Name = "Product" + i,
                    Price = rnd.Next(10, 101),

                    M1 = rnd.Next(10, 51),
                    M2 = rnd.Next(10, 51),
                    M3 = rnd.Next(10, 51),
                    M4 = rnd.Next(10, 51)
                };

                Products.Add(p);
            }
        }
    }
}
