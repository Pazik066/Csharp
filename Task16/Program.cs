// Напишите программу, которая на вход принимает два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> Да
// -4, 16 -> Да
// 25, 5 - Да
// 8, 9 -> Нет

bool IsOneSquareOfTheOther(int num1, int num2) // Название метода и ввод его переменных
{
    return num1 * num1 == num2 || num2 * num2 == num1; // Тело метода,
}

Console.WriteLine("Введите первое число"); // Запрос на ввод числа
int number1 = Convert.ToInt32(Console.ReadLine()); // Конвертация числа в 32 бита

Console.WriteLine("Введите второе число: "); // Запрос на ввод числа
int number2 = Convert.ToInt32(Console.ReadLine()); // Конвертация числа в 32 бита

bool result = IsOneSquareOfTheOther(number1, number2);
Console.WriteLine(result ? "Да" : "Нет");