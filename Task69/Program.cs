// Задача 69. Напишите программу, которая на вход принимает два числа
// А и В, и возводит число А в целую степень В с помощья рекурсии.
// А = ; B = 5; - 243


int Pow(int A, int B)
{
    if (B == 0) return 1;
    return A * Pow(A, B - 1);
}

Console.WriteLine("Введите натуральное число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень числа: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB < 0) Console.WriteLine(1 / (double) Pow(numberA, - numberB));
else Console.WriteLine(Pow(numberA, numberB));