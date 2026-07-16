double SaleNet, TypeSale, Rate, Special, Net;


SaleNet = Convert.ToDouble(Console.ReadLine());

TypeSale = Convert.ToDouble(Console.ReadLine());

if (SaleNet >= 7000_000)
{
    if (TypeSale == 1)
    {
        Rate = 0.3;
        Special = 3000;
    }
    else 
    {
        Rate = 0.25;
        Special = 2500;
    }
}
else if (SaleNet >= 5000_000)
{
    if (TypeSale == 1)
    {
        Rate = 0.2;
        Special = 2000;
    }
    else
    {
        Rate = 0.15;
        Special = 1500;
    }


}
else 
{
    Rate = 0.1;
    Special = 1000;
}

Net = SaleNet * Rate + Special;
