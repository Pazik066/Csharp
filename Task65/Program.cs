// Задача 65. Задайте значения M и N. Напишите прошрамму, 
// которая выведет все натуральные числа в промежутке от M до N.

Console.WriteLine("Введите первое натуральное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе натуральное число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 < 1 || number2 < 1)
{
    Console.WriteLine("Некорректный ввод!");
    return;
}

PrintRangeNaturalNumbers(number1, number2);

void PrintRangeNaturalNumbers (int num1, int num2)
{
    if (num1 < num2)
    {
        Console.Write($"{num1} ");
        PrintRangeNaturalNumbers(num1 + 1, num2);
    }
    else if (num1 > num2)
    {
        Console.Write($"{num1} ");
        PrintRangeNaturalNumbers(num1 - 1, num2);
    }
    else Console.Write($"{num1} ");
}