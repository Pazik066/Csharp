// Задача 28. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int MultiNumbers(int num)
{
    int multi = 1;
    for (int i = 1; i <= num; i++)
    {
        checked // Выводит ошибку, если число не помещается в 32 бита.
        {
        multi *= i;
        }
    }
    return multi;
}

Console.WriteLine("Введите целое положительное число:");
int number = Convert.ToInt32(Console.ReadLine());

int multiNumbers = MultiNumbers(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {multiNumbers}");