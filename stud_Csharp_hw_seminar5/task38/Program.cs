// // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// // [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

decimal[] CreateArray()
{
  System.Console.WriteLine("Введите размер необходимого массива:");
  int size = Convert.ToInt32(Console.ReadLine());
  decimal[] array = new decimal [size];
  return array;
}

decimal[] FillArray(decimal[] array)
{
  int check;
  Random rnd = new Random();  
  for ( int i=0; i < array.Length; i++)
      {
        check = rnd.Next(0, 2);
        array[i] = rnd.Next(0, 1000);
        if (check==0)
        array[i] = (array[i])/10;
        else if (check==1)
        array[i] = array[i]/100;
      }
  return array;
}

decimal FindMax(decimal[] array)
{
   decimal max = array[0];
   for (int i=1; i<array.Length; i++)
   {
     if (array[i]>max)
     max = array[i];
   }
   return max;
}

decimal FindMin(decimal[] array)
{
   decimal min = array[0];
   for (int i=1; i<array.Length; i++)
   {
     if (array[i]<min)
     min = array[i];
   }
   return min;
}

void PrintArray(decimal[] array)
{
    System.Console.Write("[ ");
    foreach (decimal item in array)
        System.Console.Write($"{item} ");
    System.Console.Write("]");
    System.Console.WriteLine();
}

decimal[] realArray = CreateArray();
realArray = FillArray(realArray);
PrintArray(realArray);   
if (realArray.Length>0)
{
    decimal nmax = FindMax(realArray);
    decimal nmin = FindMin(realArray); 
    System.Console.WriteLine($"max={nmax}; min={nmin}");
    System.Console.WriteLine($"max-min={nmax-nmin}");          
}
else
    System.Console.WriteLine("Массив пуст");