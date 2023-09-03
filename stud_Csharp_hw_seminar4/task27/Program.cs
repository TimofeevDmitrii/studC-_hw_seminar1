// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int DigitsSum(int num)
{
    int div = 1;
    int sum = 0;
    if (num == 0)
        return sum;
    else 
    { 
    while (num/div != 0)
    {
        div *= 10;
    }
    div = div/10;
    while (div >= 1)
    {
        sum += num/div;
        num %= div;
        div /= 10;
    }
    return sum;
    }
}
int ModulN(int N)
{
    if (N<0)
        N = -N;
    return N;    
}
System.Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
N = ModulN(N);
System.Console.WriteLine($"Сумма цифр данного числа равна {DigitsSum(N)}");
