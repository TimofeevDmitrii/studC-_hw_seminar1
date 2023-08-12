// Задача 7 HARD по желанию - идет за 2 обязательных Напишите программу, которая принимает на вход целое число любой разрядности и на выходе показывает третью цифру слева этого числа или говорит, что такой цифры нет. Через строку решать нельзя.
// 456111 -> 6
// 78 -> нет
// 9146548 -> 4
// 3 -> нет
System.Console.WriteLine("Введите целое число:");
int n = Convert.ToInt32(Console.ReadLine());
int div = 10;
if (n < 0)
    n = -n;
if (n < 100)
    System.Console.WriteLine("Нет");
else
    {
     while (n/div != 0) 
         div = div*10;
     div = div/10;
     for (int i=1; i<4; i++)
        {if (i == 3)
             System.Console.WriteLine(n/div);
         n = n%div; 
         div = div / 10;}
    }