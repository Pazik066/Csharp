// Задача 59. Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший 1
// 9 2 3 
// 4 2 4 
// 2 6 7

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

int[] GetIndexesMinElem(int[,] matrix) // Метод ищет минимальный элемент
{
    int rowMin = 0;
    int columnMin = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < matrix[rowMin, columnMin])// для поиска первого минимального
            //if (matrix[i, j] <= matrix[rowMin, columnMin]) для поиска последнего минимального элемента
            {
                rowMin = i;
                columnMin = j;
            }
        }
    }
    return new int[] {rowMin, columnMin};
}

int[,] DeleteRowColumnMinElem(int [,] matrix, int row, int column)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    for (int i = 0, m = 0; i < newMatrix.GetLength(0); i++, m++)
    {
        if (i == row) m++;
        for (int j = 0, n = 0; j < newMatrix.GetLength(1); j++, n++)
        {
            if (j == column) n++;
            newMatrix[i, j] = matrix[m, n];
        }
    }
    return newMatrix;
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2d);

Console.WriteLine();

int[] indexesMinElem = GetIndexesMinElem(array2d);

Console.WriteLine ($"row {indexesMinElem[0]}, column {indexesMinElem[1]}, value {array2d[indexesMinElem[0], indexesMinElem[1]]}");
Console.WriteLine();
int[,] newMatrix = DeleteRowColumnMinElem(array2d, indexesMinElem[0], indexesMinElem[1]);
PrintMatrix(newMatrix);