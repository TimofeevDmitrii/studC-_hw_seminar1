// задача 1 необязательная

// на входе целое или вещественное число, надо удалить вторую цифру слева этого числа.

// 1,45 -> 1,5
// 1 -> нет
// 567,123 -> 57,123

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
decimal nintegpart = 0;    // целая часть числа n;
decimal nfractionpart = 0;  // дробная часть числа n;
decimal result = 0;   // вспомогательная переменная, используемая в вычислениях;
decimal result1 = 0;   // эта переменная будет использована при нахождении первой цифры целого части n;
int i = 0; // счетчик, используемый в цикле цикле;
int f = 10; 
if (n>=0 && n<10)  // это случай, когда целая часть n меньше 10; 
    {
     while (i<10)
        {
         if (ninterm >= i && ninterm < i+1)
            {
             result = i;
             i=9;
            }
             i++;
        }
    i = 0;
     nintegpart = result; // получаем значение целой части числа n; 
     ninterm = ninterm - result;
     nfractionpart = ninterm; // получаем значение дробной части n;
     if (nfractionpart == 0)
         System.Console.WriteLine("Число состоит менее, чем из двух цифр"); 
     else
         {
         nfractionpart = 0; // необходимо заново перезаписать новую дробную часть, т.к. в противном случае в результате удаления одной цифры
         while (ninterm*10 > 0 && ninterm*10 < 10) // из дробной части n число разрядов останется неизменным и на конце дробной части будет отображаться 0 при выводе!!!
            {
             ninterm = ninterm*10;
             while (i<10)
                {
                 if (ninterm >= i && ninterm < i+1)
                     {
                      result = i;
                      i=9; 
                     }
                 i++;
                }
             i = 0;
             ninterm = ninterm - result;
             if (f != 10)
                 nfractionpart = nfractionpart + result/(f/10); // записываем значение новой дробной части
             f = f*10;
            }
        System.Console.WriteLine(k*nintegpart+k*nfractionpart);
        }
    }            
else // это случай, когда целая часть n больше, либо равна 10;
    {   
    while (n/div >= 1) // находим разрядность целой части n;
        {
        div = div*10;
        }
    div = div/10;
    for (int l=1; l<=2; l++)  // находим вторую цифру в целой части n; 
        {                      
         result = ninterm/div;
         while (i<10)
            {
             if (result >= i && result < i+1)
                 {
                  result = i;
                  i=9;
                 }
             i++;
            }
         i = 0; 
         if (l == 1)
             result1 = result;
         ninterm = ninterm - result*div;
         if (l==2)
             ninterm = ninterm + result1*div;
         div = div/10;
        }
        System.Console.WriteLine(k*ninterm);
    }