
Random num;
int[] x;

x = new int[10];
num = new Random();

//input array 1 dimension
for (int i = 0; i < 10; i++)
{
    x[i] = num.Next(10, 21);
}


//output
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(x[i]);
}

//////////////////////////////////////////

//array 2 dimension
//เช่น นศ 10 คน มีคะแนนเก็บ 2 ครั้ง


Console.WriteLine("2 dimension");
int[,] score = new int[10, 2];

for (int i = 0; i < 10; i++)  //นศ 10 คน
{
    for (int j = 0; j < 2; j++) //คะแนน 2 ครั้ง
    {
        score[i, j] = num.Next(10, 21);
    }
}


for (int i = 0; i < 10; i++)  //นศ 10 คน
{
    Console.Write($"Student {i} ");
    for (int j = 0; j < 2; j++) //คะแนน 2 ครั้ง
    {
        Console.Write($"{score[i, j]} ");
    }

    Console.WriteLine();
}


// multi dimension 3 
//เช่น นศ 10 คน เรียน 3 วิชา แต่ละวิชาสอบ 2 ครั้ง

int[,,] stud = new int[10, 3, 2];

Console.WriteLine("3 dimension");
for (int i = 0; i < 10; i++)
    for (int j = 0; j < 3; j++)
        for (int k = 0; k < 2; k++)
            stud[i, j, k] = num.Next(10, 21);

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"stud {i}");
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"\tSubject {j} : ");
        for (int k = 0; k < 2; k++)
        {
            Console.Write($"{stud[i, j, k]} ");
        }
        Console.WriteLine();
    }
}


