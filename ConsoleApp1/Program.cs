
int amount;
double num,sum=0, avg;

Console.Write("Enter amount : ");
amount = Convert.ToInt32(Console.ReadLine());

var i = 0;
while (i < amount)
{
    Console.Write("Enter num : ");
    num = Convert.ToDouble(Console.ReadLine());
    i++;
    sum += num;
}

avg = sum / amount;

Console.WriteLine($"Sum={sum} \nAvg={avg}");