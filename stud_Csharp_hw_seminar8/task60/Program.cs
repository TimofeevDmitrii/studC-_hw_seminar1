// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] CreateArray()
{
    System.Console.WriteLine();
    System.Console.WriteLine("Задайте размерность трехмерного массива. Будьте внимательны: учитывая условие задачи, размерность массива не может превышать 90 элементов");
    System.Console.WriteLine();
    System.Console.WriteLine("Введите размер массива в первом измерении (координата X):"); 
    int n1 = Convert.ToInt32(Console.ReadLine()); 
    System.Console.WriteLine("Введите размер массива во втором измерении (координата Y):"); 
    int n2 = Convert.ToInt32(Console.ReadLine()); 
    System.Console.WriteLine("Введите размер массива в третьем измерении (координата Z):"); 
    int n3 = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine();
    if (n1*n2*n3 <= 90) 
    {
        int[,,] array = new int[n1, n2, n3]; 
        return array;
    }
    else
    {
        System.Console.WriteLine("Размер задаваемого массива превышает 90 элементов");
        int[,,] array = new int[0, 0, 0];
        return array;
    }
}

bool FindNumber(int[,,] array, int num)
{ 
   for (int k = 0; k < array.GetLength(2); k++) 
        for (int j = 0; j < array.GetLength(1); j++)
            for (int i = 0; i < array.GetLength(0); i++) 
                if (num==array[i,j,k])
                    return true;    // число num есть в массиве
    return false;   // числа num нет в массиве            
}

// void CheckRepeatNumbers(int[,,] array)
// {
//    bool result = false;
//    int temp = 0;
//    int i = 0;
//    int j = 0;
//    int k = 0;
//    int l = 0;
//    int m = 0;
//    int n = 0;
//    for (k = 0; k < array.GetLength(2); k++) 
//         for (j = 0; j < array.GetLength(1); j++)
//             for (i = 0; i < array.GetLength(0); i++) 
//             { 
//                 temp = array [i,j,k];
//                 for (l=k; l < array.GetLength(2); l++)
//                     for (m=j; m < array.GetLength(1); m++)
//                         for (n=i; n < array.GetLength(0); n++)
//                             if (l!=k || m!=j || n!=i)
//                                 if (temp==array[n,m,l])
//                                 {
//                                     result = true;
//                                     System.Console.WriteLine($"В массиве повторяется число {temp}: ({i},{j},{k})\t ({n},{m},{l})"); 
//                                 }
//             }
//     if (result == false)
//         System.Console.WriteLine("Повторяющихся чисел в массиве нет");
// }

void FillArray(int[,,] array) 
{ 
    int temp;
    for (int k = 0; k < array.GetLength(2); k++) 
        for (int j = 0; j < array.GetLength(1); j++)
            for (int i = 0; i < array.GetLength(0); i++) 
                //array[i, j, k] = new Random().Next(10, 100);
            {
                do
                temp = new Random().Next(10, 100);
                while (FindNumber(array, temp)==true);
                array[i, j, k] = temp;
            }
} 

void PrintArray(int[,,] array) 
{ 
    for (int k = 0; k < array.GetLength(2); k++) 
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            System.Console.Write($"{array[i, j, k]} ({i},{j},{k})\t "); 
        System.Console.WriteLine(); 
        }
    System.Console.WriteLine();
} 

int[,,] array3n = CreateArray();
FillArray(array3n);
PrintArray(array3n);
// CheckRepeatNumbers(array3n);

