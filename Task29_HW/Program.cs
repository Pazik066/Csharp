// Задача 29. Напишите программу, которая задаёт массив из 8 элементов, 
// заполненный псевдослучайными числами и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(100);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("-> ");
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
    Console.Write(array[i] + " ");
    }
    Console.Write("]");
}

int[] createArray = CreateArray(8);

PrintArray(createArray);