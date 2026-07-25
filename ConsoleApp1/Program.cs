char type;
int hour,amountH;
double discount;

Entertype:

Console.Write("Enter type M/C/V/T : ");
type = Char.ToUpper(Console.ReadKey().KeyChar);

switch (type)
{
    case 'M': hour = 10;
        break;
    case 'C':
        hour = 30;
        break;
    case 'V':
        hour = 40;
        break;
    case 'T':
        hour = 60;
        break;
    default: Console.WriteLine("\nInvalid Vehicle Type");
        goto Entertype;
       
}

Console.Write("Enter hour :");
amountH = Convert.ToInt32(Console.ReadLine());

discount = hour > 5 ? 0.1 : 0;  //ternary condition

var total = hour * amountH;  //ราคาเต็ม
var net = total - (total * discount); //ราคามีส่วนลด

Console.WriteLine($"Output: Parking Fee = {net} Baht");

