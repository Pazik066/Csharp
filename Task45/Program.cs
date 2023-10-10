// Напишите программу, которая будет создавать  копию заданного массива с помощью поэлементного копирования.


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

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int[] CopyArray(int[] arr)
{
    int[] copy = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        copy[i] = arr[i];
    }
    return copy;
}

int[] firstArray = CreateArrayRndInt(8, 1, 11);
Console.Write("[");
PrintArray(firstArray);
Console.WriteLine("]");

int[] secondArray = CopyArray(firstArray);
Console.Write("[");
secondArray[0] = -1;
PrintArray(secondArray);
Console.WriteLine("]");