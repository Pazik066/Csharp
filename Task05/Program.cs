// Напишите программу, которая 
// 1. на вход принимает одно число (N)
// 2. на выходе показывает целые числа в промежутке от -N до N
// Например: 
// 4 -> "-4, -3, -2 , -1 , 0, 1, 2, 3, 4"

Console.WriteLine("Введите целое положительное число: ");

int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
int count = -number;

while (count <= number)
{
    Console.Write($"{count} ");
    count++;
}
}
else Console.WriteLine("Некорректный ввод");