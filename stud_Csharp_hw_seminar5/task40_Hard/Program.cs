//задача 40 - HARD необязательная. На вход программы подаются три целых положительных числа. 
//Определить , является ли это сторонами треугольника. 
//Если да, то вывести всю информацию по нему - площадь, периметр, значения углов треугольника в градусах, 
//является ли он прямоугольным, равнобедренным, равносторонним.

using System;

public class Test
{
 static int[] CreateLengthsArray()
{
    int[] lengths = new int [3];
    string[] sideNames = {"a", "b", "c"};
    for (int i=0; i<lengths.Length; i++)
    { 
        System.Console.WriteLine($"Введите длину стороны {sideNames[i]} (целое положительное число):");
        lengths[i]= Convert.ToInt32(Console.ReadLine());
    }
    return lengths;
}

static bool IsItTriangle(int[] lengths)
{
    if (lengths[0]<lengths[1]+lengths[2] && lengths[1]<lengths[0]+lengths[2] && lengths[2]<lengths[0]+lengths[1])
        return true;
    else 
        return false;
}

static double[] CountAngles(int[] lengths)
{
    string[] sideNames = {"a", "b", "c"};
    string[] angleNames = {"A", "B", "C"};
    double[] angles= new double[3];
    double cos= 0;
    for (int i=0; i<angles.Length; i++)   
    {
        for (int k=0; k<lengths.Length; k++) // вычисляем числитель дроби в формуле косинуса угла треугольника
        {
            if (k!=i)
                cos +=Math.Pow(lengths[k],2);
            else
                cos -=Math.Pow(lengths[k],2);
        }
        for (int j=0; j<lengths.Length; j++) //вычисляем знаменатель дроби в формуле косинуcа угла треугольника и делим на него числитель
        {
            if (j!=i)
                cos/=lengths[j];
            else
                cos = cos/2;
        } 
        angles[i]= Math.Acos(cos); //получили значение угла в радианах
        angles[i]= 180*angles[i]/Math.PI;  // перевели радианы в градусы
        angles[i]= Math.Round(angles[i],2);
        System.Console.WriteLine($"Угол {angleNames[i]} = {angles[i]} град. (противолежащий стороне {sideNames[i]})");
        cos=0;
    }
    return angles;
}

static int CountPerimeter(int[] lengths)
{
    int p = 0;
    foreach (int item in lengths)
        p = p + item;
    return p; 
}

static double CountSquareGeron(double p, int[] lengths)
{
    double s = Math.Sqrt((p/2)*((p/2)-lengths[0])*((p/2)-lengths[1])*((p/2)-lengths[2]));
    s = Math.Round(s,2);
    return s;
}

static double CountSquare(int[] lengths, double[] angles)
{
    int k = new Random().Next(0,3);
    // System.Console.WriteLine(k);
    double s = 1;
    for (int i = 0; i<lengths.Length; i++) // s = (sinA*b*c)/2 - т.е. произведение двух прилежащих сторон на синус угла между ними, разделенное пополам
    {
        if (i == k)
            s *= Math.Sin(angles[i]*Math.PI/180)/2; // находим значение синуса угла, деленного пополам, между двумя сторонами треугольника
        else
            s *= lengths[i];
    }
    s = Math.Round(s,2);
    return s; 
}

static void FindExtraCharacteristics(int[] lengths, double[] angles)
{
    for (int i = 0; i<angles.Length; i++)
    {
        if (angles[i]==90)
            System.Console.WriteLine("Данный треугольник прямоугольный");
    } 
    if (lengths[0]==lengths[1]||lengths[0]==lengths[2]||lengths[1]==lengths[2])
        System.Console.WriteLine("Данный треугольник равнобедренный");
    if (lengths[0]==lengths[1]&&lengths[0]==lengths[2])
        System.Console.WriteLine("Данный треугольник равноcторонний");
}

static void PrintArray(double[] array)
{
    System.Console.Write("[ ");
    foreach (double item in array)
        System.Console.Write($"{item} ");
    System.Console.Write("]");
    System.Console.WriteLine();
}
 public static void Main()
 {
    int[] triangleLengths=CreateLengthsArray();
    if (IsItTriangle(triangleLengths)==true)
    {
        // PrintArray(triangleLengths);
        double[] triangleAngles=CountAngles(triangleLengths);
        int perimeter = CountPerimeter(triangleLengths);
        System.Console.WriteLine($"Периметр данного треугольника P = {perimeter}");
        System.Console.WriteLine($"Площадь по формуле Герона Sgeron = {CountSquareGeron(perimeter,triangleLengths)}");
        System.Console.WriteLine($"Площадь через высоту Sh = {CountSquare(triangleLengths, triangleAngles)}");
        FindExtraCharacteristics(triangleLengths,triangleAngles);
    }
    else 
        System.Console.WriteLine("Треугольник с такими сторонами не может существовать!");
 }
}
