// Задача 41. Пользователь вводит M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223 -> 3

int[] CreateArray(int length)
{
    int[] arr = new int[length];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите {i + 1} элемент: ");
        int elem = Convert.ToInt32(Console.ReadLine());
        arr[i] = elem;
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

int CountPositiveNum(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

Console.Write("Сколько чисел будет в массиве?: "); 
int sizeArray = Convert.ToInt32(Console.ReadLine());

int[] createArray = CreateArray(sizeArray);
Console.Write("[");
PrintArray(createArray);
Console.WriteLine("]");

Console.WriteLine("Количество чисел больше 0: "); 
int countPositiveNum = CountPositiveNum(createArray);
Console.WriteLine($"{countPositiveNum}");