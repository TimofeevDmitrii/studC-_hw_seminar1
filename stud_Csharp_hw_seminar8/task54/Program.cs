// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void RowitemsFromMaxToMin (int[,] array)
{
    int count = 0;
    int k = 0;
    for (int i=0; i<array.GetLength(0); i++)
    {
        k = 0;
        do
        {
            count = 0;
            for (int j=0; j<array.GetLength(1)-1-k; j++)
            {
                if (array[i,j]<array[i,j+1])
                {
                    (array[i,j],array[i,j+1])=(array[i,j+1],array[i,j]);
                    count += 1;
                }
            }
            k += 1;
        }
        while (count!=0);
    }
}

int[,] testArray = CreateArray();
FillArray(testArray);
PrintArray(testArray);
RowitemsFromMaxToMin(testArray);
PrintArray(testArray);