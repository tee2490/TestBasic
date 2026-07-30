//while Pretest

var num = 1;

while (num < 5) {
    Console.WriteLine($"While {num}");
    num++;

}

Console.WriteLine("For");

for (int i = 1; i < num; i++)
{
    Console.WriteLine($"For {i}");
}


//PostTest
Console.WriteLine("do..while");
num = 1;
do 
{
    Console.WriteLine($"While {num}");
    num++;
} while (num < 5);