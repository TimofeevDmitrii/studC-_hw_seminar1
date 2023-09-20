// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string PrintNumsFromNTo1(int n)
{
    if (n==1)
        return $"{n}";
    else
        return $"{n}, "+PrintNumsFromNTo1(n-1);
}

System.Console.WriteLine("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(PrintNumsFromNTo1(n));


