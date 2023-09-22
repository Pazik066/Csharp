// Напишите программу, которая
// 1. На вход принимает два числа
// 2. Проверяет, является ли первое число квадратом второго
// 3. Выводит "да", "нет"
// Например: а = 25, b = 5 -> да
// a = 2, b = 10 -> нет

Console.WriteLine("Введите 1 число: ");

int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 2 число: ");

int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2 * number2)
{
    Console.WriteLine($"{number1} является квадратом {number2}");
}
else
{
    Console.WriteLine($"{number1} не явлется квадратом {number2}");
}