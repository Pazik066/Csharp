// Задача 68. Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Ack(numberN, numberM));

int Ack(int n, int m)
{
    if (n == 0) return m + 1;
    if (m == 0) return Ack (n - 1, 1);
    return Ack (n - 1, Ack (n, m - 1));
}