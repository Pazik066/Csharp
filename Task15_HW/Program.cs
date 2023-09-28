// 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

bool Weekend(int weekDay)
{
if (weekDay >= 1  && weekDay <= 5)
    return false;
return true;
}

Console.WriteLine("Введите номер"); 
int weekDay = Convert.ToInt32(Console.ReadLine()); 

bool result = Weekend(weekDay);
if (weekDay < 8) Console.WriteLine(result ? "Да" : "Нет");
else Console.WriteLine($"Это не номер дня недели!");