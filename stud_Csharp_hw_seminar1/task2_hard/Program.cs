// Задача 2 HARD по желанию Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
// 456 -> 3
// 0 -> 1
// 89,126 -> 5
// 0,001->4


System.Console.WriteLine("Введите число:");
decimal n = Convert.ToDecimal(Console.ReadLine());
int k = 1; 
if (n<0)
    {
    n = -n;  // если введенное число окажется меньше нуля, то необходимо взять его модуль;
    k = -1;  // меняем значение k на минус 1, это необходимо в конце при выводе целой и дробной частей n;
    }
decimal ninterm = n;     // промежуточное значение n, используемое для вычислений;
int div = 1;   // делитель;
int numberofdigits = 1;  //переменная для хранения количества цифр в числе n;
decimal nholepart = 0;    // целая часть числа n;
decimal nfractionpart = 0;  // дробная часть числа n;
decimal result = 0;   // вспомогательная переменная, используемая в вычислениях;
int i = 0; // счетчик, используемый в цикле цикле;
if (n == 0)  // в случае, если введенное число равно нулю;
    numberofdigits = 1;
else if (n>0 && n<1)  // это случай, когда целая часть n равна нулю, а дробная не равна нулю; 
    {
     nfractionpart = ninterm;
     while (ninterm*10 > 0 && ninterm*10 < 10)
            {
             ninterm = ninterm*10;
             while (i<10)
                {
                 if (ninterm > i && ninterm < i+1)
                     {
                      result = i;
                      i=9; 
                     }
                 i++;
                }
             i = 0;
             ninterm = ninterm - result;
             numberofdigits++;
            }
    }            
else // это случай, когда целая часть n не равна нулю;
    {   
    while (n/div >= 1) // находим разрядность целой части n;
        {
        div = div*10;
        numberofdigits++; // попутно считаем количество цифр в целой части;
        }
    div = div/10;
    numberofdigits = numberofdigits-1; 
    while (div>=1)             // исключаем целую часть из числа n, т.е. необходимо, чтобы в конце цикла 
        {                      // в переменной ninterm осталась только дробная часть числа n;
         result = ninterm/div;
         while (i<10)
            {
             if (result > i && result < i+1)
                 {
                  result = i;
                  i=9;
                 }
             i++;
            }
         i = 0;
         nholepart = nholepart + result*div; // в цикле попутно получаем значение целой части числа n; 
         ninterm = ninterm - result*div;
         div = div/10;
        }
    nfractionpart = ninterm; // после цикла получаем дробную часть числа n;
    if (ninterm>0)           // в случае, если дробная часть n не равна нулю, то тогда 
        {                    // считаем количество цифр в дробной части;              
         while (ninterm*10 > 0 && ninterm*10 < 10)
            {
             ninterm = ninterm*10;
             while (i<10)
                {
                 if (ninterm > i && ninterm < i+1)
                     {
                      result = i;
                      i=9;
                     }
                 i++;
                }
             i = 0;
             ninterm = ninterm - result;
             numberofdigits++;  // прибавляем к количеству цифр в целой части колчичество цифр в дробной части 
            }
        }
    }
System.Console.WriteLine($"в веденном числе {numberofdigits} цифр(а/ы)");
System.Console.WriteLine($"целая часть числа равна {k*nholepart}");
System.Console.WriteLine($"дробная часть числа равна {k*nfractionpart}");
