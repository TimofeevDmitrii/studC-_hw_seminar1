// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateArray(string matrixName)
{
    System.Console.WriteLine($"Введите количество строк матрицы {matrixName}:"); 
    int rows = Convert.ToInt32(Console.ReadLine()); 
    System.Console.WriteLine($"Введите количество столбцов матрицы {matrixName}:"); 
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

bool MultiplyPossibility(int[,] arrayA, int[,] arrayB) 
{
    if (arrayA.GetLength(1)!=arrayB.GetLength(0))
        return false;
    else
        return true;
    
}

int[,] MultiplyMatrix(int[,] arrayA, int[,] arrayB) 
{
    int[,] multiplyResult = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i=0; i<multiplyResult.GetLength(0); i++)
        for (int j=0; j<multiplyResult.GetLength(1); j++)
            for (int k=0; k<arrayA.GetLength(1); k++)
                multiplyResult[i,j] += arrayA[i,k]*arrayB[k,j];
    return multiplyResult;
}

int[,] matrixA = CreateArray("A");
FillArray(matrixA);
PrintArray(matrixA);
int[,] matrixB = CreateArray("B");
FillArray(matrixB);
PrintArray(matrixB);
if (MultiplyPossibility(matrixA, matrixB)==true)
{
    int[,] matrixC = MultiplyMatrix(matrixA, matrixB);
    System.Console.WriteLine("Произведение матрицы A на матрицу B равно (Матрица C):");
    PrintArray(matrixC);
}
else
System.Console.WriteLine("Умножение матриц невозможно - матрицы A и B не согласованы");


