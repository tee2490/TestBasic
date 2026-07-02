double a, b, x, y;
a = b = 1;
x = 2;
y = 3;

//var กำหนดตัวแปรแบบไม่ระบุชนิดข้อมูล (var) จะให้ตัวแปรนั้นมีชนิดข้อมูลตามค่าที่กำหนดให้
var num1 = (a + b ) / (3 * a * b);
var num2 = (x * x* y * y) / (x - y);
var result = num1 - num2;

Console.WriteLine(result);