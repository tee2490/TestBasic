
double money,special,total,tax;



//input
money = Convert.ToDouble(Console.ReadLine());


//process
special = money * 0.03;
total = money + special;

if (total > 500000) tax = total * .1;
else tax = total * 0.05;

//output
Console.WriteLine(tax);