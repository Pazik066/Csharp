// Задача 57. Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.


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

int[] MatrixToArray(int[,] matrix)
{
    int[] array = new int[matrix.Length];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k] = matrix[i, j];
            k++;
        }
    }
    return array;
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

void PrintFrequancyDictionary(int[] array)
{
    int count = 1;
    int currentNumber = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == currentNumber) count++;
        else
        {
            Console.WriteLine($"{currentNumber,3} -> {count,3}");
            currentNumber = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"{currentNumber,3} -> {count,3}");
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2d);
Console.WriteLine();
int[] arr = MatrixToArray(array2d);
Array.Sort(arr); // Сортировка
PrintArray(arr);
Console.WriteLine();
PrintFrequancyDictionary(arr);