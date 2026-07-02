//declare
double status, price, quantity, discount=0, tax, netPrice;

//input
Console.Write("Enter customer status: [1=Member 9=Non-Member]");
status = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter price: ");
price = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter quantity: ");
quantity = Convert.ToDouble(Console.ReadLine());

//process
var TotalPrice = price * quantity;

if (status == 1) { 
    discount = TotalPrice * 0.1;
}

//หลังจากคำนวณราคาสุทธิแล้วให้คำนวณภาษีมูลค่าเพิ่ม 7% และราคาสุทธิหลังหักส่วนลดและบวกภาษี
tax = (TotalPrice - discount) * 0.07;
netPrice = TotalPrice - discount + tax;


//output
Console.WriteLine("Net Price: " + netPrice);
