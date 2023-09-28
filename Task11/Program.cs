// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 - 46
// 782 - 72 
// 918 - 98

int number = new Random().Next(100, 1000);

int delSecondDigit = DelSecondDigit(number);
Console.WriteLine($"{number} -> {delSecondDigit}");

int DelSecondDigit(int num)
{
    int firstDigit = num / 100;
    int lastDigit = num % 10;
    int numResult = firstDigit * 10 + lastDigit;
    return numResult;
}