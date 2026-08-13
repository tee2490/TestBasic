using ConsoleApp1.Models;

namespace ConsoleApp1.Services
{
    public class Generate  //บริการ สร้าง แก้ ลบ ค้น CRUD
    {
        List<Product> products = new List<Product>();
        Random rnd = new Random();

        public void Create() //method
        {
            for (int i = 0; i < 10; i++)
            {
                products.Add(new Product()
                {
                    Id = i,
                    Name = "Prduct" + i,
                    Price = rnd.Next(10, 21)
                });
            }

        }


        public void Show()
        {
            products.ForEach(p =>p.Display());
        }


    }
}
