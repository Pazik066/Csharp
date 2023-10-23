// Задача 48. Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле:
// Amn = m + n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3 
// 1 2 3 4
// 2 3 4 5

int[,] CreateMatrixSumIndex(int rows, int columns) // Вводим двумерный массив, название (строки, столбцы, мин, макс)
{
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++) // Цикл для строк
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // Цикл для столбцов
        {
            matrix[i, j] = i + j;
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

int[,] arraySum = CreateMatrixSumIndex(3, 4);
PrintMatrix(arraySum);