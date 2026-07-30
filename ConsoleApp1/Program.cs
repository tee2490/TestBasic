
int amount;
double num,sum=0, avg;

Console.Write("Enter amount : ");
amount = Convert.ToInt32(Console.ReadLine());

for (var i = 0; i < amount; i++)
{
    Console.Write("Enter num : ");
    num = Convert.ToDouble(Console.ReadLine());
    sum += num;
}

avg = sum / amount;

Console.WriteLine($"Sum={sum} \nAvg={avg}");