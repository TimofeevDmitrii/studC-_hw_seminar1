// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int CountPositiveNumbers()
{
    int countPositiveNum = 0;
    string? NumbersRow = Console.ReadLine();
    string number = "";
    for (int i=0; i<NumbersRow.Length; i++)
    {
        string currenti = NumbersRow[i].ToString();
        if ( currenti == " " || currenti == ",")
            {   
                if (number == "")
                    number = "0";
                if (Convert.ToInt32(number)>0)
                    countPositiveNum += 1;
                number = "";
            }
        else
            {
               number += currenti;
               if(i == NumbersRow.Length-1)
                    {
                    if (Convert.ToInt32(number)>0)
                        countPositiveNum += 1;
                    }
            }
    }
    return countPositiveNum;
}
System.Console.WriteLine("Введите ряд целых чисел: ");
int countPos = CountPositiveNumbers();
System.Console.WriteLine($"Количество чисел больше нуля в данном ряду: {countPos}"); 
