// Задача 66. Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите первое натуральное число: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе натуральное число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if(numberM < 1 || numberN < 1)
{
    Console.WriteLine("Некорректный ввод!");
    return;
}

int SumOfDigits(int M, int N)
{
if (M==N) return 0;
else return M + SumOfDigits(M + 1, N);
}

if (numberM < numberN) Console.Write($"Сумма натуральных элементов в промежутке от M до N равно {SumOfDigits(numberM,numberN + 1)}");
else if (numberM > numberN) Console.Write($"Сумма натуральных элементов в промежутке от M до N равно {SumOfDigits(numberN,numberM + 1)}");