// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.WriteLine("Введите первое целое число a:");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе целое число b:");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
    Console.WriteLine($"a={a}; b={b}; max=a={a}");
else if (a == b)
    Console.WriteLine($"a={a}; b={b}; a=b");
else 
    Console.WriteLine($"a={a}; b={b}; max=b={b}");
