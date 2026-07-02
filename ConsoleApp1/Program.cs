//declare
string Id;
double Year, Salary, Bonus=0;


//input
Console.Write("Enter employee ID: ");
Id= Console.ReadLine();

Console.Write("Enter years of service: ");
Year = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter salary: ");
Salary = Convert.ToDouble(Console.ReadLine());


//process
if (Year >= 3)
{
    Bonus = Salary * 2;
}

//output
Console.WriteLine("Bonus: " + Bonus);