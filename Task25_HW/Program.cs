// Задача 25. Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную сепень В.
// 3, 5 -> 243
// 2, 4 -> 16


int DegreeNumber(int num1, int num2)
{
    int numDegree = 1;
    for (int i = 0; i < num2; i++)
    {
        numDegree = numDegree * num1;
    }
    return numDegree;
}



Console.WriteLine("Введите целое число A:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число B:");
int number2 = Convert.ToInt32(Console.ReadLine());

int degreeNumber = DegreeNumber(number1, number2);
Console.WriteLine($"Число А в степени В = {degreeNumber}");