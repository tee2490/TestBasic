double income, tax, rate;

income = Convert.ToDouble(Console.ReadLine());

if (income < 100000)
{
    rate = 0;
}
else if (income < 500001)
{
    rate = 0.05;
}
else if (income < 1000000)
{ 
    rate = 0.1; 
}
else
    rate = 0.15;

tax= income * rate;

Console.WriteLine($"Income: {income}, Tax Rate: {rate}%, Tax: {tax}");