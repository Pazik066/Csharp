// Задача 26. Напишите программу, которая принимает на вход число и выдаёт количесвто цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int QuantityNumber(int num)
{
    if (num == 0) return 1;
    int count = 0;
    while (num != 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}



Console.WriteLine("Введите целое положительное число:");
int number = Convert.ToInt32(Console.ReadLine());

int quantityNumber = QuantityNumber(number);
Console.WriteLine($"Количесвто цифр в числе: {quantityNumber}");