// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateArray()
{
    System.Console.WriteLine("Введите количество строк задаваемого массива:"); 
    int rows = Convert.ToInt32(Console.ReadLine()); 
    System.Console.WriteLine("Введите количество столбцов задаваемого массива:"); 
    int cols = Convert.ToInt32(Console.ReadLine()); 
    int[,] array = new int[rows, cols]; 
    System.Console.WriteLine();
    return array;
}

void FillArray(int[,] array) 
{ 
    for (int i = 0; i < array.GetLength(0); i++) 
        for (int j = 0; j < array.GetLength(1); j++) 
            array[i, j] = new Random().Next(1, 10); 
} 

void PrintArray(int[,] array) 
{ 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
            System.Console.Write($"{array[i, j]}\t "); 
        System.Console.WriteLine(); 
    } 
    System.Console.WriteLine();
} 

void FindMinRowSum(int[,] array)
{
    int minSum = 0;
    int minRow = 0;
    int currentSum = 0;
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        currentSum = 0;
        for (int j = 0; j < array.GetLength(1); j++) 
            currentSum += array[i,j]; 
        if (i==0)
        {    
            minSum = currentSum;
            minRow = i+1;
        }
        else
            if (currentSum<minSum)
            {
                minSum = currentSum;
                minRow = i+1;
            }
    } 
    System.Console.WriteLine($"Строка с наименьшей суммой элементов - {minRow}");
}
int[,] testArray = CreateArray();
FillArray(testArray);
PrintArray(testArray);
FindMinRowSum(testArray);
