// 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Method(int numberMetod)
{
    while (numberMetod > 999)
    {
        numberMetod /= 10;
    }
    return numberMetod % 10;
}

int number = new Random().Next();
Console.WriteLine($"Случайное число -> {number}");

int requiredNumber = Method(number);
if (number > 99) Console.WriteLine($"{requiredNumber}");
else Console.WriteLine($"Третьей цифры нет");