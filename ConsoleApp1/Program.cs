int[] num= new int[10];
Random random = new Random();
 
//input
for(int i = 0; i < num.Length; i++) num[i] = random.Next(1,101);

var max = num[0];
var min = num[0];

//process
for (int i = 1; i < num.Length; i++)
{ 
  if(num[i] > max) max = num[i];
  if(num[i] < min) min = num[i];
}

//output
for (int i = 0; i < num.Length; i++) Console.WriteLine($"no.{i} = {num[i]}");

Console.WriteLine($"Max={max}\nMin={min}");