// Задача 55. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно,
// программа должна вывести сообщение для пользователя.

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

// void ReplaceRowsColumns(int[,] matrix)
// {        
//     for (int i = 0; i < matrix.GetLength(0) -1; i++)
//         {
//             for (int j = i + 1; j < matrix.GetLength(1); j++)
//             {
//                 int temp = matrix[i, j];
//                 matrix[i, j] = matrix[j, i];
//                 matrix[j, i] = temp;
//             }
//         }
// }

void ReplaceRowsColumns(int[,] matrix)
{        
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < i; j++)
            {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[j, i];
                matrix[j, i] = temp;
            }
        }
}


int[,] array2d = CreateMatrixRndInt(3, 3, -10, 10);
PrintMatrix(array2d);
Console.WriteLine();
ReplaceRowsColumns(array2d);
PrintMatrix(array2d);