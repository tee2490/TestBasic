Random num;
double num1,even=0,odd=0,SumEven=0,SumOdd=0,AvgEven,AvgOdd;

num = new Random();

var count = 0;
for (int i = 0; i < 100; i++)
{
    num1 = num.Next(20, 31);
    Console.Write($"{num1} ");

    if (num1 % 2 == 0)
    { 
        even++;
        SumEven += num1;

    }
    else 
    { 
        odd++; 
        SumOdd += num1;
    }

    count++;
    if (count == 10)
    {
        Console.WriteLine();
        count = 0;
    }

}

AvgEven = SumEven / even;
AvgOdd = SumOdd / odd;

Console.WriteLine("Type\tNumber\tSum\tAverage");
Console.WriteLine($"Even\t{even}\t{SumEven}\t{AvgEven:F2}");
Console.WriteLine($"Odd\t{odd}\t{SumOdd}\t{AvgOdd:F2}");
