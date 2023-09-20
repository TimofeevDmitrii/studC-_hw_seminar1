// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int FindSumFromMintoMax(int min, int max)
{
    if (min==max)
        return max;
    else
        return min+FindSumFromMintoMax(min+1,max);
}

System.Console.WriteLine("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {FindSumFromMintoMax(m,n)}");
