//declare
string Code, Name;
double Salary, Sale,Rate, Commission,Net;

//input
Console.Write("Enter code :");
Code = Console.ReadLine();

Console.Write("Enter name :");
Name = Console.ReadLine();

Console.Write("Enter salary :");
Salary = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter sale :");
Sale = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter rate 1-100 : ");
Rate = Convert.ToDouble(Console.ReadLine());

//process
Commission = Sale * (Rate/100);
Net = Salary + Commission;

//output
Console.WriteLine($"Commission = {Commission}");
Console.WriteLine($"Net = {Net}");



/// priority     + - * / ( ) จากซ้ายไปขวา ทำ (), ทำ * / ก่อน,  + -



