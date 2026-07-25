Console.Write("Enter Type (H/S/F) : ");
char type = char.ToUpper(Console.ReadKey().KeyChar);

Console.Write("\nEnter Units : ");
double unit = Convert.ToDouble(Console.ReadLine());

double total = 0;

switch (type)
{
    case 'H':
        total = unit * 4.50;
        if (unit > 300) total *= 0.95;
        break;

    case 'S':
        total = unit * 5.80;
        if (unit > 300) total *= 0.97;
        break;

    case 'F':
        total = unit * 6.70;
        break;

    default:
        Console.WriteLine("Invalid Type");
        return;
}

Console.WriteLine("Electricity Bill = {0:F2} Baht", total);
