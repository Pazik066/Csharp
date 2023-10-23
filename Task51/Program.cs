// Задача 51. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали
// (с идексами [0,0]; [1;1] и т.д.)
// Например 
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1 + 9 + 2 = 12.


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max) // Вводим двумерный массив, название (строки, столбцы, мин, макс)
{
    //                         0        1  Индексы измерений массива
    int[,] matrix = new int[rows, columns]; // Создаём массив, добвляем количесвто строк и столбцов
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) // Цикл для строк
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // Цикл для столбцов
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
} // Этот метод фиксируется по столбцам, чтобы фиксировать по строкам, нужно поменять циклы местами.

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("    |");
    }
}

int SumElemMainDiagonal(int[,] matrix)
{
    int sum = 0;
    // int minSize = matrix.GetLength(0);
    // if (minSize > matrix.GetLength(1)) minSize = matrix.GetLength(1);

    // for (int i = 0; i < minSize; i++)
    for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
    {
        sum += matrix[i, i];
    }
    return sum;
}

int[,] array2d = CreateMatrixRndInt(3, 5, 1, 10);
PrintMatrix(array2d);

int sumElemMainDiagonal = SumElemMainDiagonal(array2d);
Console.WriteLine($"Сумма элементов главной диагонали: {sumElemMainDiagonal}");