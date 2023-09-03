// using System;
// public class Answer
// { 
//  private static double DistanceBetweenPoints(int [] pointA, int [] pointB)
//  {
//   double distance=Math.Pow(pointA[0]-pointB[0],2)+Math.Pow(pointA[1]-pointB[1],2)+Math.Pow(pointA[2]-pointB[2],2);
//   distance=Math.Sqrt(distance);
//    return distance;
//     }
//  static public void Main()
//  {
//   int [] A = {7, -5, 0};
//   int [] B = {1, -1, 9};
//   Console.WriteLine($"distance from A to B: {DistanceBetweenPoints(A, B):F2}");
//  }
// }

using System;

public class Answer
{
    private static double DistanceBetweenPoints(int[] pointA, int[] pointB)
    {
      double distance = Math.Pow(pointA[0]-pointB[0],2)+Math.Pow(pointA[1]-pointB[1],2)+Math.Pow(pointA[2]-pointB[2],2);
      distance=Math.Sqrt(distance);
      return distance;
    }
  // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args) {
        int x1, x2, x3, y1, y2, y3;

        if (args.Length >= 6) {
            x1 = int.Parse(args[0]);
            x2 = int.Parse(args[1]);
            x3 = int.Parse(args[2]);
            y1 = int.Parse(args[3]);
            y2 = int.Parse(args[4]);
            y3 = int.Parse(args[5]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            x1 = 7;
            x2 = -5;
            x3 = 0;
            y1 = 1;
            y2 = -1;
            y3 = -9;
        }

        // Не удаляйте строки ниже
        double result = DistanceBetweenPoints(new int[]{x1, x2, x3}, new int[]{y1, y2, y3});
        Console.WriteLine($"{result:F2}");
    }
}
