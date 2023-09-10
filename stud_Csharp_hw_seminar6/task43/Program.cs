// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

decimal[] InsertParams()
{
    string[] paramsNames = {"k1","k2","b1","b2"};
    decimal[] taskParams = new decimal [4];
    for (int i=0; i<taskParams.Length; i++)
    {
        System.Console.WriteLine($"Введите значение {paramsNames[i]}: ");
        taskParams[i] = Convert.ToDecimal(Console.ReadLine());
    } 
    return taskParams;
}

decimal[] FindCrossPoint(decimal[] paramsArray)
{
    string[] varNames = {"x","y"};
    decimal[] crossPoint = new decimal [2];
    crossPoint[0] = (paramsArray[3]-paramsArray[2])/(paramsArray[0]-paramsArray[1]);
    System.Console.WriteLine($"x = {crossPoint[0]}");
    crossPoint[1] = paramsArray[0]*crossPoint[0]+paramsArray[2];
    System.Console.WriteLine($"y = {crossPoint[1]}");
    return crossPoint;
}

void PrintArray(decimal[] array)
{
    System.Console.Write("( ");
    for (int i = 0; i<array.Length; i++)
        {
        if (i!=array.Length-1)
        System.Console.Write($"{array[i]}; ");
        else
        System.Console.Write($"{array[i]} ");    
        }
    System.Console.Write(")");
    System.Console.WriteLine();
}

decimal[] par = InsertParams();
decimal[] cross = FindCrossPoint(par);
System.Console.WriteLine("Точка пересечения прямых, заданных этими параметрами:");
PrintArray(cross);