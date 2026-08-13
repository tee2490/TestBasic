using ConsoleApp1.Models;

List<int> nums = new List<int>(); //ไม่จำกัด
int[] test = new int[10]; //จำกัดจำนวน

Random random = new Random();

for (int i = 0; i < 10; i++)
{ 
    nums.Add(random.Next(10,101));
}


//foreach (var item in nums)
//{
//    Console.WriteLine(item);
//}


nums.ForEach(x => Console.WriteLine(x)); //lamda