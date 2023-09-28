// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа. 
// 78 - 8
// 12 - 2
// 85 - 8

int MaxDigit(int num)
{
    int firstDigit = num / 10; // 78 / 10 = 7,8 - двухначное число делим на 10, чтобы получить первую цифру число (целочисленное деление - остаток отбрасывается)
    int secondDigit = num % 10; // % означает остаток от деления (78 / 10 = 7,8 - остаток 8)

    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int number = new Random().Next(10, 100);

Console.WriteLine($"Случайное число из отрезка [10,99] -> {number}");

// int firstDigit = number / 10; // 78 / 10 = 7,8 - двухначное число делим на 10, чтобы получить первую цифру число (целочисленное деление - остаток отбрасывается)
// int secondDigit = number % 10; // % означает остаток от деления (78 / 10 = 7,8 - остаток 8)

// //if(firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");
// //else Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");

// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;

//Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

