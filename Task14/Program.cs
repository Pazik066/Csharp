// 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> Нет 
// 46 -> Нет
// 161 -> Да


bool MultipleOfTwoNumbers(int num, int num1, int num2) // Название метода и ввод его переменных
{
    return num % num1 == 0 && num % num2 == 0; // Тело метода, в котором проверяется кратность введенного числа, по отношению к двум другим числам
}

Console.WriteLine("Введите число: "); // Запрос на ввод числа
int number = Convert.ToInt32(Console.ReadLine()); // Конвертация числа в 32 бита

bool result = MultipleOfTwoNumbers(number, 7, 23); // Вызов метода
Console.WriteLine(result ? "Да" : "Нет"); // Вывод результата