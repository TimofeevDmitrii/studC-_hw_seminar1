// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Решение через строку
// char thirdnum='0';
// System.Console.WriteLine("Введите целое число");
// string? number = Console.ReadLine();
// if ((number.Length)<3)
//     System.Console.WriteLine("Третьей цифры нет");
// else
//     {
//      thirdnum = number[2];
//      System.Console.WriteLine($"{thirdnum}");
//     }

System.Console.WriteLine("Введите целое число:");
int n = Convert.ToInt32(Console.ReadLine());
int div = 10;
if (n < 0)
    n = -n; //если введенное число окажется меньше нуля, то необходимо взять его модуль
if (n < 100)
    System.Console.WriteLine("Третьей цифры нет");
else
    {
     while (n/div != 0) 
         div = div*10;
     div = div/10;
     for (int i=1; i<4; i++)
        {
         if (i == 3)
             System.Console.WriteLine(n/div);
         n = n%div; 
         div = div / 10;
         }
    }


