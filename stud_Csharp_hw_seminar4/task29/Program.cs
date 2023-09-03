// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// случайных целых чисел от 1 до 50 и выводит их на экран.
int[] Makearray()
{
    int[] array = new int [8];
    for (int i=0; i<8; i++)
    {
        array[i] = new Random().Next(1,51);
    }
    return array;
}
void Printarray(int[] A)
{
    for (int i=0; i<8; i++)
    {
        System.Console.Write($"{A[i]} ");
    }
    System.Console.WriteLine();
}
int[] arr = Makearray();
Printarray(arr);
