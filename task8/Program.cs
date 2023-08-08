// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.WriteLine("Введите целое число (большее, чем число 1):");
int n = Convert.ToInt32(Console.ReadLine());
int m = 2;
while (m <= n) {
    if (m%2 == 0)
        System.Console.Write($"{m} ");
    m = m+1; }
System.Console.WriteLine();
    
