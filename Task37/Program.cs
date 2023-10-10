﻿// Задача 37. Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и так далее.
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


using System.Diagnostics;

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

int[] ProductPairsNumbers(int[] arr)
{
    int size = arr.Length / 2 + arr.Length % 2;
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = arr[i] * arr[arr.Length - i - 1];
    }
    if (arr.Length % 2 != 0) result[size - 1] = arr[arr.Length / 2];
    return result;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int[] array = CreateArrayRndInt(5, 1, 9);
PrintArray(array);

int[] newArray = ProductPairsNumbers(array);
PrintArray(newArray);


// Методы создания массива с вещественными числами и вывода с окурглением до одного число после запятой.

// double[] CreateArrayRndDouble(int size, int min, int max)
// {
//     double[] arr = new double[size];
//     Random rnd = new Random();
//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = rnd.NextDouble() * (max - min) + min;
//     }
//     return arr;
// }

// void PrintArrayDouble(double[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1) Console.Write($"{arr[i]:F1}, ");
//         else Console.Write($"{arr[i]:F1}");
//     }
//     Console.WriteLine("]");
// }