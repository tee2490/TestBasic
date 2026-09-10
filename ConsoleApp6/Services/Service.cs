using ConsoleApp6.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6.Services
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
            Console.WriteLine($"{"ID",10} {"Prod.",10} {"Price",5}" +
                   $"{"B1",4} {"B2",4} {"B3",4} {"Total",6} {"Value",12:N0}");

            Console.WriteLine(new string('-', 60));

            foreach (var p in Products)
            {
                Console.WriteLine($"{p.Id,10} {p.Name,10} {p.Price,5}" +
                    $"{p.B1,4} {p.B2,4} {p.B3,4} {p.Total(),6} {p.Value(),12:N0}");
            }

            var sumB1 = Products.Sum(p => p.B1);
            var sumB2 = Products.Sum(p => p.B2);
            var sumB3 = Products.Sum(p => p.B3);
            var sumTotal = Products.Sum(p => p.Total());
            var sumVal = Products.Sum(p => p.Value());
            Console.WriteLine($"{"TOTAL",10} {sumB1,20} {sumB2,4} {sumB3,4} " +
                $"{sumTotal,6} {sumVal,12:N0}");

            var maxTotal = Products.Max(p=>p.Total());
            var maxProducts = Products.Where(p=>p.Total() == maxTotal).ToList();

            var minTotal = Products.Min(p => p.Total());
            var minProducts = Products.Where(p => p.Total() == minTotal).ToList();

            Console.Write($"Max stock Products {maxTotal} : ");
            foreach (var item in maxProducts)
            {
                Console.Write($" {item.Name} ");
            }

            Console.WriteLine();

            Console.Write($"Min stock Products {minTotal} : ");
            foreach (var item in minProducts)
            {
                Console.Write($" {item.Name} ");
            }

            var maxBranch = Math.Max(Math.Max(sumB1, sumB2),sumB3);

            Console.Write($"\nMax Total Branch = {maxBranch} ");

            if (sumB1 == maxBranch)
                Console.Write("B1 ");

            if (sumB2 == maxBranch)
                Console.Write("B2 ");

            if (sumB3 == maxBranch)
                Console.Write("B3 ");

            Console.WriteLine();

            Console.WriteLine($"sum total = {sumTotal}");
            Console.WriteLine($"sum value = {sumVal}");


        }

        public void Mock(int num = 5)
        {
            for (int i = 0; i < num; i++)
            {
                var prod = new Product()
                {
                    Id = "P00" + i,
                    Name = "Product" + i,
                    Price = rnd.Next(10,5001),
                    B1 = rnd.Next(1,21),
                    B2 = rnd.Next(1, 21),
                    B3 = rnd.Next(1, 21),
                };

                Products.Add(prod);
            }
        }

    }
}
