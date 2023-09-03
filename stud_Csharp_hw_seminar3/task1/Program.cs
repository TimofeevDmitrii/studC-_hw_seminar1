// Палиндром

// Инструкция по использованию платформы



// Внутри класса Answer напишите метод IsPalindrome, который принимает на вход пятизначное число number и проверяет, является ли оно палиндромом.

// Метод должен проверить является ли число пятизначным, в противном случае - вывести Число не пятизначное и False в следующей строке.

// Для остальных чисел вернуть True или False.

// 14212 -> False
// 12821 -> True
// 234322 -> Число не пятизначное
  
// using System;
// public class Answer
// { 
//     static bool IsPalindrome(int number)
//         {
//             bool res;
//             int startnumber = number;
//             int finishnumber = 0;
//             int div=10000;
//             if (number/10000 == 0 || number/100000 != 0)
//             {
//                 Console.WriteLine("Число не пятизначное");
//                 res = false;
//                 Console.WriteLine(res);
//             }
//             else
//             { 
//                 int count = 1;
//                 for (int i=0; i<5; i++)
//                 {
//                     finishnumber += (number/div)*count;
//                     number = number%div;
//                     div/=10;
//                     count*=10;
//                 }
//                 if (finishnumber==startnumber)
//                     res=true;
//                 else
//                 {
//                     res=false;
//                     Console.WriteLine($"Результат: {startnumber}, {finishnumber} ");
//                 }
//             }
//                 return res;
//         }
//     static public void Main()
//     {
//         Console.WriteLine("введите число");
//         int n = Convert.ToInt32(Console.ReadLine());
//         bool result= IsPalindrome(n);
//         Console.WriteLine($"{n} --> {result}");
//     }
// }

using System;

public class Answer
{
    static bool IsPalindrome(int number){
            bool res;
            int startnumber = number;
            int finishnumber = 0;
            int div=10000;
            if (number/10000 == 0 || number/100000 != 0)
            {
                Console.WriteLine("Число не пятизначное");
                res = false;
            }
            else
            { 
                int count = 1;
                for (int i=0; i<5; i++)
                {
                    finishnumber += (number/div)*count;
                    number = number%div;
                    div/=10;
                    count*=10;
                }
                if (finishnumber==startnumber)
                    res=true;
                else
                {
                    res=false;
                }
            }
                return res;
    }
  
  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 40308;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}

