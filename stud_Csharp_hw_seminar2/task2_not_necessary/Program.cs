// Задача 2 НЕОБЯЗАТЕЛЬНАЯ.

// Напишите программу для. проверки истинности утверждения ¬(X ⋁ Y ⋁ Z) = ¬X ⋀ ¬Y ⋀ ¬Z (Теорема Де Моргана) .
// Но теперь количество предикатов не три, а генерируется случайным образом от 5 до 25, сами значения предикатов случайные, проверяем это утверждение 100 раз, 
// выводим на экран , сколько времени отработала программа. В конце вывести результат проверки истинности этого утверждения.


// using System;             // подклчаем пространство имен System
using System.Diagnostics;    // подключаем пространство имен Diagnostics из пространства имен System

public class Program 
{ 
    public static void Main()
    {
        bool[] Makearray()
        {                  
            int l = new Random().Next(5,26);   //Создаем массив с предикатами; число предикатов в массиве (от 5 до 25);
            bool [] statements = new bool[l];
            System.Console.WriteLine($"Был сгенерирован массив из {l} предикатов");
            for (int k=0; k<l; k++)
                {
                 int m = new Random().Next(0,2); //  значения предикатов случайные;
            if (m==0)
                statements [k] = false;
            else
                statements[k] = true; 
                }
            return statements; 
        }
        bool Leftside(bool[] stmnt)    // Вычисляем значение левого выражения равенства;
        {
        bool result = false;
        for (int i=0; i<stmnt.Length-1; i++)
            {
                if (i==0)
                    result = stmnt[i] || stmnt [i+1];
                else 
                    result = result || stmnt [i+1];
            }
            result = !result;
            return result;
        }
        bool[] Invertarray(bool[] stmnt) // инвертируем значения в массиве предикатов;
        {
            for (int i=0; i<=stmnt.Length-1; i++)
                stmnt[i]=!stmnt[i];
            return stmnt;
        }
        bool Rightside(bool[] stmnt)  // вычисляем значение правой части равенства;
        {
            bool result = false;
            for (int i=0; i<stmnt.Length-1; i++)
                {
                    if (i==0)
                        result = stmnt[i] && stmnt [i+1];
                    else 
                        result = result && stmnt [i+1];
                }
            return result;
        } 
        System.Console.WriteLine("Введите число необходимых повторений: ");
        int f = Convert.ToInt32(Console.ReadLine());
        int luck = 0;
        Stopwatch time = new Stopwatch(); 
        time.Start(); 
        for (int k=1; k<=f; k++)
            {
                bool[] array = Makearray();
                bool resultleft = Leftside(array);
                array = Invertarray(array);
                bool resultright = Rightside(array);
                System.Console.Write($"{k} ");
                if (resultleft == resultright)
                    {
                        System.Console.WriteLine("OK!!!");
                        luck = luck+1;
                    }
                else 
                System.Console.WriteLine("------Not equal------!!!");
            }
        if (luck == f)
            System.Console.WriteLine($"Данное утверждение истинно (в {luck} случаях из {f} случаев утверждение верно)");
        else
            System.Console.WriteLine($"Утверждение неверно в {f-luck} случаях");
        time.Stop(); 
        Console.WriteLine($"{time.ElapsedMilliseconds} millyiseconds");
    }
}
