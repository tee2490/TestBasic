using ConsoleApp1.Models;

namespace ConsoleApp1.Services
{
    public class Generate  //บริการ สร้าง แก้ ลบ ค้น CRUD
    {
        static List<Product> products;
        Random rnd; 

        public Generate() //Constuctor : Method พิเศษที่ทำงาน อัตโนมัติเมื่อสร้าง Object
        {
            products = new List<Product>();
            rnd = new Random();
        }


        public Generate(int newNum=5) //ctor
        {
            products = new List<Product>();
            rnd = new Random();
            Create(newNum);
            Show();
        }

        public void Create(int num=10) //method
        {
            for (int i = 0; i < num; i++)
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
            Console.Clear();
            products.ForEach(p =>p.Display());
        }


        public void AddData()
        {
            var p = new Product();

            Console.Write("Enter id : ");
            p.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter name : ");
            p.Name = Console.ReadLine();

            Console.Write("Enter price : ");
            p.Price = Convert.ToInt32(Console.ReadLine());


            products.Add(p);
            Show();

        }


    }
}
