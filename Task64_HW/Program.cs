// Задача 64. Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. 

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 1)
{
    Console.WriteLine("Некорректный ввод!");
    return;
}

PrintNaturalNumbers(number);

void PrintNaturalNumbers (int num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    PrintNaturalNumbers(num - 1);
}