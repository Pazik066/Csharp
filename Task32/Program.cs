// Задача 32. Напишите программу замена элементов массива:
// положительные элементы замените на соответсвующие отрицательные и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[12];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void InversArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int[] array = CreateArrayRndInt(12, -9, 9);

Console.Write("[");
PrintArray(array);
Console.WriteLine("]");

InversArray(array);

Console.Write("[");
PrintArray(array);
Console.WriteLine("]");