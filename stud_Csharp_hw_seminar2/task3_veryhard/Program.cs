// Задача 3 VERY HARD.

// Необходимо реализовать три алгоритма сортировки одномерного массива - пузырьком, быстрой сортировкой, методом подсчета. 
// Исходный массив заполняется случайными целыми числами. Далее провести ряд экспериментов с различной размерностью массива, 
// засечь время выполнения каждого, объяснить в соответствии с нотацией Big O полученные результаты. 
// Выполнять всё с помощью методов. Рассказать про плюсы и минусы каждого алгоритма.

using System.Diagnostics;

int InsertSize()
{
    int l = 0;
    do 
        {
            System.Console.WriteLine("Введите размер сортируемого одномерного массива:");
            string? str = Console.ReadLine();
            if (str == "")
            {    
                System.Console.WriteLine("Вы не обозначили длину массива!");
                l = -1;
            }
            else
            {
                l = Convert.ToInt32(str);
                if (l<0)
                    System.Console.WriteLine("Размер массива не может быть отрицательным. Попробуйте еще раз.");
            }
        }
    while (l<0);    
    return l;
}

int[] MakeArray(int length)
{
    int[] newArray = new int [length];
    Random rnd = new Random();
    for (int i=0; i<length; i++)
        {
            newArray[i]= rnd.Next(0,101);
        }
    return newArray;
}

void PrintArray(int[] array)
{
    if (array.Length==0)
        System.Console.WriteLine("Массив пуст");
    else
    {
        for (int i=0; i<array.Length; i++)
        {
            System.Console.Write($"{array[i]} ");
        }
    }
    System.Console.WriteLine();
}

int[] BubbleSort(int[] unsortArr)
{
    if (unsortArr.Length<=1)
        return unsortArr;
    else
    { 
        int count = 0; // переменная будет каждый раз увеличиваться на 1, если произошла перестановка элементов
        //  во время прохода по массиву; к следующему проходу по массиву переменная обнуляется;
        int m = 0; // переменная будет увеличиваться на единицу каждый раз, когда совершен один проход по массиву;
        do 
        {
            count = 0; 
            int k = 0; // буферная переменная
            for (int i=0; i<unsortArr.Length-1-m; i++)
            {
                if (unsortArr[i]>unsortArr[i+1])
                {
                k = unsortArr[i+1];
                unsortArr[i+1] = unsortArr[i];
                unsortArr[i] = k;
                count = count+1;
                }
            }
            m = m+1;
        }
        while (count != 0); // как только не зафиксировано ни одной перестановки элементов в массиве за проход,
        // то можно сделать стоп - массив отсортирован;
        return unsortArr;
    }
}

int [] FastSort(int[] unSortA)
{    
    Random rnd = new Random();
    if (unSortA.Length<=1)  // База рекурсии
        return unSortA;
    else
    {
        int i = rnd.Next(0, unSortA.Length); // Выбираем опорный элемент в сортируемом массиве
        // найдем длины вспомогательных массивов
        int lessLength = 0;  //длина массива с элементами меньше, чем опорный, или равными опорному элементу
        int upperLength = 0; // длина массива с элементами больше, чем опорный
        // Длины вспомогательных массивов будут равны:
        // less - количеству элементов меньше опорного или равных опорному элементу
        // upper - количеству элементов больше опорного   
        for (int q=0; q<unSortA.Length; q++)
        {
            if (q!=i) 
                if (unSortA[q]<=unSortA[i])
                    lessLength++;
                else
                    upperLength++;
        }
        //узнав длины, создаем вспомогательные массивы
        int[] less = new int [lessLength]; 
        int l = 0; // номер ячейки в массиве less, в которую будет заноситься новый элемент из unSortA
        int[] upper = new int [upperLength]; 
        int u = 0; // номер ячейки в массиве upper, в которую будет заноситься новый элемент из unSortA
        for (int k=0; k<unSortA.Length; k++)
        {
            if (k!=i)
            {
                if (unSortA[k]<=unSortA[i])
                {
                    less[l]=unSortA[k]; // заносим новый элемент в следующую по порядку ячейку в массиве less
                    l++; // увеличиваем номер следующей ячейки на 1
                }
                else
                {
                    upper[u]=unSortA[k]; // заносим новый элемент в следующую по порядку ячейку в массиве upper
                    u++; // увеличиваем номер следующей ячейки на 1
                }
            }
        }
        less = FastSort(less); // применяем рекурсивно метод быстрой сортировки к массивам less и upper
        upper = FastSort(upper);
        int[] endSortA = new int[less.Length+1+upper.Length]; // создаем итоговый массив, полученный слиянием 
        // массива с элементами меньше опорного, либо равными опорному, опорного элемента и массива с элементами 
        // больше опорного
        if (less.Length==0)
            endSortA[0]=unSortA[i];
        else
        {
            for (int j=0; j<less.Length; j++)
                endSortA[j] = less[j];
            endSortA[less.Length]=unSortA[i];
        }
        for (int j=0; j<upper.Length; j++)
            endSortA[less.Length+1+j] = upper[j];
        return endSortA;
    }    
} 

Stopwatch time = new Stopwatch(); 

int size = InsertSize();
int[] arr = MakeArray(size);
// PrintArray(arr);
time.Start();
int[] arrBubble = BubbleSort(arr);
time.Stop(); 
Console.WriteLine($"Сортировка методом 'пузырька' заняла {time.ElapsedMilliseconds} миллисекунд");
// PrintArray(arrBubble);
time.Reset();
time.Start();
int[] arrFast = FastSort(arr);
time.Stop(); 
Console.WriteLine($"Сортировка методом быстрой сортировки заняла {time.ElapsedMilliseconds} миллисекунд");
// PrintArray(arrFast);
