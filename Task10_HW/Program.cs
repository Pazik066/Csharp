// 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


int Method(int numMethod) // Название метода и ввод его переменных
{
    return numMethod / 10 % 10;
}

Console.WriteLine("Введите трёхзначное целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) number *= -1;

if (number >= 100 && number <= 999)
{
    int result = Method(number);
    Console.WriteLine($"Вторая цифра числа: {result}");
}
else Console.WriteLine($"Неверный ввод");