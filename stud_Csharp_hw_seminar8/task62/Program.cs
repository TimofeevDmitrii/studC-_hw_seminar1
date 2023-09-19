// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateArray()
{
    System.Console.WriteLine("Введите необходимую размерность массива n*n (неотрицательное целое число n):");
    int n = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine();
    int[,] array = new int[n, n];
    return array;
}

void PrintArray(int[,] array) 
{ 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
            System.Console.Write("{0:00}\t ", array[i, j]); 
        System.Console.WriteLine(); 
    } 
    System.Console.WriteLine();
} 

void SpiralFillArray(int[,] array)
{
    int n = array.GetLength(0);
    int count = 0;
    int x = 1;
    int i = 0;
    int j = 0;
    while(x<=Math.Pow(n,2))
    {
        while (j<=n-1-count)
        {
            array[i,j] = x;
            x++;
            j++;
        }
        i++;
        j--;
        while (i<=n-1-count)
        {
            array[i,j] = x;
            x++;
            i++;
        }
        i--;
        j--;
        while(j>=count)
        {
            array[i,j] = x;
            x++;
            j--;
        }
        i--;
        j++;
        count++;
        while(i>=count)
        {
            array[i,j] = x;
            x++;
            i--;
        }
        i++;
        j++;
    }
}

int[,] testArray = CreateArray();
SpiralFillArray(testArray);
PrintArray(testArray);

