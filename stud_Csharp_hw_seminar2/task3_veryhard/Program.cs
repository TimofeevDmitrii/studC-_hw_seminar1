// Задача 3 VERY HARD.

// Необходимо реализовать три алгоритма сортировки одномерного массива - пузырьком, быстрой сортировкой, методом подсчета. 
// Исходный массив заполняется случайными целыми числами. Далее провести ряд экспериментов с различной размерностью массива, 
// засечь время выполнения каждого, объяснить в соответствии с нотацией Big O полученные результаты. 
// Выполнять всё с помощью методов. Рассказать про плюсы и минусы каждого алгоритма.
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
        int[] less = new int [0];  // массив с элементами меньше, чем опорный, или равными опорному элементу
        int[] upper = new int [0]; // масиив с элементами больше, чем опорный
        for (int k=0; k<unSortA.Length; k++)
        {
            if (k!=i)
            {
                if (unSortA[k]<=unSortA[i])
                {
                    int[] interLess = new int [less.Length+1]; // буферный массив для создания нового массива less 
                    for (int l=0; l<less.Length; l++)  // копируем элементы из less в буферный массив
                        interLess[l] = less[l];    
                    interLess[interLess.Length-1]=unSortA[k]; // добавляем в конец буферного массива новый элемент
                    less = interLess; // фиксируем все изменения в массиве less
                }
                else
                {
                    int[] interUpper = new int[upper.Length+1]; // буферный массив для создания нового массива upper
                    for (int l=0; l<upper.Length; l++)   // копируем элементы из upper в буферный массив
                        interUpper[l] = upper[l];    
                    interUpper[interUpper.Length-1]=unSortA[k]; // добавляем в конец буферного массива новый элемент
                    upper = interUpper; // фиксируем все изменения в массиве upper
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
            for (int l=0; l<less.Length; l++)
                endSortA[l] = less[l];
            endSortA[less.Length]=unSortA[i];
        }
        for (int l=0; l<upper.Length; l++)
            endSortA[less.Length+1+l] = upper[l];
        return endSortA;
    }    
} 

int size = InsertSize();
int[] arr = MakeArray(size);
PrintArray(arr);
int[] arrBubble = BubbleSort(arr);
PrintArray(arrBubble);
int[] arrFast = FastSort(arr);
PrintArray(arrFast);
