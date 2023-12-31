﻿// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём Х не равно 0 и Y не равно 0 и выдаёт номер четверти плоскости, в которой находится эта точка
// 
// Если Х > 0 и Y > 0, значит 1 четверть
// Если Х < 0 и Y > 0, значит 2 четверть
// Если Х < 0 и Y < 0, значит 3 четверть
// Если Х > 0 и Y < 0, значит 4 четверть


int Quater(int x,int y) // Метод
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4; // Условия
    return 0; // Возврат нуля при невыполнении ни одного условия
}

Console.WriteLine("Введите координаты точки"); // Запрос на ввод координат
Console.WriteLine("X: "); // продолжение
int xCoordinate = Convert.ToInt32(Console.ReadLine()); // Конвертация
Console.WriteLine("Y: "); // Продолжение запроса
int yCoordinate = Convert.ToInt32(Console.ReadLine()); // Конвертация

int quater = Quater(xCoordinate, yCoordinate); // Вызов метода
string result = quater > 0 ? $"Указанные координаты соответсвуют четверти {quater}" : "Введены некорректные координаты"; // Тернарный оператор, создаем переменную
                                                                            // Если больше нуля ? тогда формируем строку для вывода переменной : иначе возвращаем строку

Console.WriteLine(result);