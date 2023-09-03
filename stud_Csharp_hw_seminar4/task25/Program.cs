// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
void ExpAinB()
{
    System.Console.WriteLine("Введите число А:");
    int A = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите число В:");
    int B = Convert.ToInt32(Console.ReadLine());
    double exp = Math.Pow(A,B);
    System.Console.WriteLine($"{A}^{B}={exp}");
}
for ( ; ;)
{
ExpAinB();
}