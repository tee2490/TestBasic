//declare
string Id;
double Salary, PSale, Rate, Num, Bonus=0, Bonus1=0;

//input
Console.Write("Enter employee ID: ");
Id = Console.ReadLine();

Console.Write("Enter salary: ");
Salary = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter total sales: ");
PSale = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter commission rate [0-1]: ");
Rate = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter number of cars sold: ");
Num = Convert.ToDouble(Console.ReadLine());

//process
var Commission = PSale * Rate;

if(Num > 5)
{
    Bonus = 9000;
}

if(Commission > Salary)
{
    Bonus1 = PSale * 0.1;
}

var net = Salary + Commission + Bonus + Bonus1;

//output
Console.WriteLine("Commission: "+Commission);
Console.Write("Salary: " + Salary);
Console.WriteLine("Total Income: " + net);