// Задача 22. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от одного до N.
// 5 -> 1, 4, 9, 16, 25
// 2 -> 1, 4


void TableSquare(int num) // Метод который ничего не возвращает
{
    int count = 1;
    while(count <= num) 
    {
        Console.WriteLine($"{count, 3} {count * count, 5}"); // Вывод на экран с форматированием, 
                                                             //  означает длину строки в кторую помещяется резулитат
        count++;
    }
}

Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

TableSquare(number);