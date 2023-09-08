// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray()
{
    System.Console.WriteLine("Введите размер необходимого массива:");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int [size];
    return array;
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100,101);
}

void PrintArray(int[] array)
{
    System.Console.Write("[ ");
    foreach (int item in array)
        System.Console.Write($"{item} ");
    System.Console.Write("]");
    System.Console.WriteLine();
}

int SumOfOddPositionNums(int[] array)
{
    int countOddNumSum = 0;
    for (int i=0; i<array.Length; i++)
    {
       if (i%2 != 0)
           countOddNumSum += array[i]; 
    }
    return countOddNumSum;
}

int[] testArray = CreateArray();
FillArray(testArray);
PrintArray(testArray);
System.Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях в массиве: {SumOfOddPositionNums(testArray)}");