// Задача 53. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.


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
void ReplaceFirstLastRows(int[,] matrix)
{
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[0, j];
            matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
            matrix[matrix.GetLength(0) - 1, j] = temp;
        }
}


int[,] array2d = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2d);
Console.WriteLine();
ReplaceFirstLastRows(array2d);
PrintMatrix(array2d);