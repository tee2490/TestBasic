using ConsoleApp8.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8.Services
{
    public class Service : IService
    {
        private List<Product> Products;
        private List<int> SumQs;
        private Random rnd;

        public Service()
        {
            Products = new List<Product>();
            SumQs = new List<int>();
            rnd = new Random();
        }

        public void Display()
        {
            Console.WriteLine($"{"Id",7}{"Name",10}{"Cost",8}{"Price",8}{"Q1",4}{"Q2",4}" +
                $"{"Q3",4}" +
                  $"{"Q4",4}" +
                  $"{"TotalQ",10}{"TotalR",12}{"Profit",12}");


            foreach (var p in Products)
            {
                Console.WriteLine($"{p.Id,7}{p.Name,10}{p.Cost,8}{p.Price,8}{p.Q1,4}{p.Q2,4}{p.Q3,4}" +
                    $"{p.Q4,4}" +
                    $"{p.TotalQuantity(),10}{p.TotalRevenue(),12:N0}{p.Profit(),12:N0}");
                
            }

            var sumQ1 = Products.Sum(p => p.Q1);
            var sumQ2 = Products.Sum(p => p.Q2);
            var sumQ3 = Products.Sum(p => p.Q3);
            var sumQ4 = Products.Sum(p => p.Q4);
            var sumTotalQ = Products.Sum(p => p.TotalQuantity());
            var sumTotalR = Products.Sum(p => p.TotalRevenue());
            var sumProfit = Products.Sum(p=>p.Profit());

            SumQs.Add(sumQ1);
            SumQs.Add(sumQ2);
            SumQs.Add(sumQ3);
            SumQs.Add(sumQ4);

            Console.WriteLine($"{sumQ1,37}{sumQ2,4}{sumQ3,4}" +
                   $"{sumQ4,4}" +
                   $"{sumTotalQ,10}{sumTotalR,12:N0}{sumProfit,12:N0}");
        }

        public void MockData(int n=10)
        {
            for (int i = 0; i < n; i++) 
            {
                var p = new Product()
                {
                    Id = "P00" + i,
                    Name = "Coffee" + i,
                    Cost = rnd.Next(100, 501),
                    Price = rnd.Next(300, 1001),
                    Q1 = rnd.Next(10, 31),
                    Q2 = rnd.Next(10, 31),
                    Q3 = rnd.Next(10, 31),
                    Q4 = rnd.Next(10, 31),
                };

                Products.Add(p);
            }
        }

        public void Summary()
        {
            var p = Products.OrderByDescending(p=>p.TotalQuantity()).First();
            var pf = Products.OrderByDescending(p=>p.Profit()).First();
            
            var bestQ = SumQs.Max();
            var index = SumQs.IndexOf(bestQ);

            var sumRev = Products.Sum(p => p.TotalRevenue());
            var sumProfit = Products.Sum(p=>p.Profit());
            var avgProfit = Products.Average(p => p.Profit());


            Console.WriteLine($"{p.Name} {p.TotalQuantity()}");
            Console.WriteLine($"{pf.Name} {pf.Profit()}");

            Console.WriteLine($"Q{index+1} {bestQ}");

            Console.WriteLine(sumRev);
            Console.WriteLine(sumProfit);
            Console.WriteLine(avgProfit);
        }
    }
}
