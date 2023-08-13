// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
int num=0;
int digit=0;
do 
{
 System.Console.WriteLine("Введите целое трехзначное число:");
 num = Convert.ToInt32 (Console.ReadLine());
 if (num < 0)
     num = -num;
 if (num<100 || num > 999)
     System.Console.WriteLine("Вы ввели число неверной разрядности. Попробуйте еще раз");
}
while (num<100 || num > 999);
digit = num/100;
num = num - digit*100;
digit = num/10;
System.Console.WriteLine(digit);
