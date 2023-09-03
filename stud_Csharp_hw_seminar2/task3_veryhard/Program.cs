// Задача 3 VERY HARD.

// Необходимо реализовать три алгоритма сортировки одномерного массива - пузырьком, быстрой сортировкой, методом подсчета. 
// Исходный массив заполняется случайными целыми числами. Далее провести ряд экспериментов с различной размерностью массива, 
// засечь время выполнения каждого, объяснить в соответствии с нотацией Big O полученные результаты. 
// Выполнять всё с помощью методов. Рассказать про плюсы и минусы каждого алгоритма.
int Insertsize()
{
    int l = 0;
    do 
        {
            System.Console.WriteLine("Введите размер сортируемого одномерного массива:");
            string str = Console.ReadLine();
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

int[] Makearray(int length)
{
    int[] newarray = new int [length];
    for (int i=0; i<length; i++)
        {
            newarray[i]= new Random().Next(0,101);
        }
    return newarray;
}

void Printarray(int[] A)
{
    if (A.Length==0)
        System.Console.WriteLine("Массив пуст");
    else
    {
        for (int i=0; i<A.Length; i++)
        {
            System.Console.Write($"{A[i]} ");
        }
    }
    System.Console.WriteLine();
}

// int[] Bubblesort(int[] unsortarr)
// {
//     if (unsortarr.Length<=1)
//         return unsortarr;
//     else
//     { 
//         int count = 0;
//         do 
//         {
//             count = 0;
//             int k = 0;
//             for (int i=0; i<unsortarr.Length-1; i++)
//             {
//                 if (unsortarr[i]>unsortarr[i+1])
//                 {
//                 k = unsortarr[i+1];
//                 unsortarr[i+1] = unsortarr[i];
//                 unsortarr[i] = k;
//                 count = count+1;
//                 }
//             }
//         }
//         while (count != 0);
//         return unsortarr;
//     }
// }

int [] Fastsort(int[] unsortA)
{
    if (unsortA.Length<=1)
        return unsortA;
    else
    {
        int i = new Random().Next(0, unsortA.Length);
        System.Console.WriteLine(i);
        System.Console.WriteLine(unsortA[i]);
        int[] less = new int [0];
        int[] upper = new int [0];
        for (int k=0; k<unsortA.Length; k++)
        {
            if (unsortA[k]!=unsortA[i])
            {
                if (unsortA[k]<=unsortA[i])
                {
                    int[] interless = new int [less.Length+1]; ///// остановился последний раз здесь!!!!
                    if (less.Length!=0)
                    {
                        Array.Copy(less,0,interless,0,less.Length);
                    }    
                    interless[interless.Length-1]=unsortA[k];
                    less = interless;
                }
                else
                {
                    int[] interupper = new int[upper.Length+1];
                    if (upper.Length!=0)
                    {
                        Array.Copy(upper,0,interupper,0,upper.Length);
                    }    
                    interupper[interupper.Length-1]=unsortA[k];
                    upper = interupper;
                }
            }
        }
        int[] endsortA = new int[less.Length+1+upper.Length];
        System.Console.WriteLine($"lengthless={less.Length}, lengthupper={upper.Length}, endsortA={endsortA.Length}");
        less = Fastsort(less);
        upper = Fastsort(upper);
        if (endsortA.Length!=2)
        {
            if (less.Length!=0)
            {
            Array.Copy(less,0,endsortA,0,less.Length);
            if (upper.Length==0)
                endsortA[endsortA.Length-1]=unsortA[i];
            else
                endsortA[i]=unsortA[i];
            }
            if (upper.Length!=0)
            {
                if (less.Length==0)
                {
                    endsortA[0]=unsortA[i];
                    Array.Copy(upper,0,endsortA,i+1,upper.Length);
                }
                else
                {
                    endsortA[0]=unsortA[i];
                    Array.Copy(upper,0,endsortA,1,upper.Length);
                }
            }
        }
        else
        {
            if (less.Length!=0)
            {
                endsortA[0]=less[0];
                endsortA[1]=unsortA[i];
            }
            if (upper.Length!=0)
            {
                endsortA[0]=unsortA[i];
                endsortA[1]=upper[0];
            }
        }
        return endsortA;
    }    
} 

int size = Insertsize();
int[] arr = Makearray(size);
Printarray(arr);
// int[] arrbubble = Bubblesort(arr);
// Printarray(arrbubble);
int[] arrfast = Fastsort(arr);
Printarray(arrfast);
