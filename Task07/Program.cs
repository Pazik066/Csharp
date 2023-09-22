// Напишите программу, которая 
// 1. Принимает на вход трёхзначное число
// 2. На выходе показывает последнюю его цифру
// Например: 
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите трёхзначное целое число: ");

int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) number *= -1;

if (number >= 100 && number <= 999)
{

    int lastDigit = number % 10;

    Console.WriteLine($"Последняя цифра числа: {lastDigit}");
}
else Console.WriteLine("Некорректный ввод");