using ConsoleApp1.Services;

var ps = new Generate();

ps.Create(10);

int menu;

do
{
    Console.Clear();

    Console.WriteLine("===== PRODUCT CRUD =====");
    Console.WriteLine("1. Show Product");
    Console.WriteLine("2. Add Product");
    Console.WriteLine("3. Update Product");
    Console.WriteLine("4. Delete Product");
    Console.WriteLine("5. Search Product");
    Console.WriteLine("0. Exit");
    Console.WriteLine("========================");

    Console.Write("Select menu : ");
    menu = Convert.ToInt32(Console.ReadLine());

    switch (menu)
    {
        case 1:
            ps.Show();
            break;

        case 2:
            ps.AddData();
            break;

        case 3:
            ps.UpdateData();
            break;

        case 4:
            ps.DeleteData();
            break;

        case 5:
            var result = ps.Search();

            if (result != null)
            {
                Console.WriteLine(
                    $"{result.Id} {result.Name} {result.Price}"
                );
            }
            else
            {
                Console.WriteLine("Not found");
            }
            break;

        case 0:
            Console.WriteLine("Exit Program");
            break;

        default:
            Console.WriteLine("Invalid menu");
            break;
    }

    if (menu != 0)
    {
        Console.WriteLine();
        Console.Write("Press any key...");
        Console.ReadKey();
    }

} while (menu != 0);