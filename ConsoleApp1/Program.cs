using ConsoleApp1.Services;

var ps = new Generate(); //Method พิเศษที่ทำงาน อัตโนมัติเมื่อสร้าง Object

//เรียก ctor  Generate(int newNum=5)
var ps1 = new Generate(8);


Console.WriteLine("Call ctor Generate");
ps.Create();
ps.Show();
