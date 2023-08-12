// Задача 2 HARD по желанию Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
// 456 -> 3
// 0 -> 1
// 89,126 -> 5
// 0,001->4

// System.Console.WriteLine("Введите число:");
// decimal n = Convert.ToDecimal(Console.ReadLine());
// decimal div = 3;
// System.Console.WriteLine($"div={div}");
// decimal result=n/div;
// System.Console.WriteLine(result);
// int i=0;
// while (i < 10)
//     {
//      if (result > i & result < (i+1))
//          {
//           result = i;
//           i=9;
//          }
//      i=i+1;
//      System.Console.WriteLine("счетчик+");
//     }
// System.Console.WriteLine($"hole part of result = {result}");


System.Console.WriteLine("Введите число:");
decimal n = Convert.ToDecimal(Console.ReadLine());
if (n<0)
    n = -n;
decimal ninterm = n;
int div = 1;
int numberofdigits = 1;
decimal nholepart = 0;
decimal nfractionpart = 0;
decimal result = 0;
int i = 0;
if (n == 0)
    System.Console.WriteLine(numberofdigits);
else if (n>0 & n<1)
    {
     System.Console.WriteLine("число меньше 1");
     nfractionpart = ninterm;
     while (ninterm*10 > 0 & ninterm*10 < 10)
            {
             ninterm = ninterm*10;
             while (i<10)
                {
                 if ((ninterm > i) & (ninterm < (i+1)))
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
else 
    {   
    while ((n/div) >= 1)
        {
        div = div*10;
        numberofdigits++;
        }
    div = div/10;
    numberofdigits = numberofdigits-1;
    while (div>=1)
        {
         result = ninterm/div;
         while (i<10)
            {
             if ((result > i) & (result < (i+1)))
                 {
                  result = i;
                  i=9;
                 }
             i++;
            }
         i = 0;
         nholepart = nholepart + result*div;
         ninterm = ninterm - result*div;
         div = div/10;
        }
    nfractionpart = ninterm;
    if (ninterm>0) 
        {
         while (ninterm*10 > 0 & ninterm*10 < 10)
            {
             ninterm = ninterm*10;
             while (i<10)
                {
                 if ((ninterm > i) & (ninterm < (i+1)))
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
    }
System.Console.WriteLine(nholepart);
System.Console.WriteLine(nfractionpart);
System.Console.WriteLine(numberofdigits);