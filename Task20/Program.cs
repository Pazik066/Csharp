// Задача 20. Напишите программу, которая принимает на вход координаты двух точек и находи расстояние между ними в 2D пространстве.
// А (3, 6); В (2, 1) -> 5,09
// A (7;-5); B (1,-1) -> 7,21

// Math.Pow(5, 6); // вызов метода, который возводит число в степень, возвращает тип данных Double.
// Math.Sqrt(5); // вызов метода , который извлекает корень, возвращает тип данных Double.

// double d = 5.09953345; // Вводим переменную
// double dRound = Math.Round(d, 2, MidpointRounding.ToZero); // округление с использованием еще отдного метода
//                                                             // (переменная, количество чисел, стратегия округления)

// System.Console.WriteLine(dRound);

double FindDistace(int ax, int ay, int bx, int by)
{
    int leg1 = ax - bx;
    int leg2 = ay - by;
    double distance = Math.Sqrt(leg1 * leg1 + leg2 * leg2);
    return distance;
}

Console.WriteLine("Введите координаты точки A");
Console.Write("X: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.Write("X: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double result = FindDistace(x1 , y1, x2, y2);
double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine(resultRound);

Console.WriteLine($"{d:F2}"); // Способ округления без стратегий. {переменная, количество знаков};