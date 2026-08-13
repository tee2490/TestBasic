using ConsoleApp1.Models;

List<Product> products = new List<Product>();
Random rnd = new Random();

for (int i = 0; i < 100; i++)
{
    var test = new Product() //สินค้า 1 รายการ
    {
        Id = i,
        Name = "Product"+i,
        Price=rnd.Next(10,21)
    };

    products.Add(test); //เพิ่มสินค้าเข้าไปใน list
}


products.ForEach(p => p.Display());


