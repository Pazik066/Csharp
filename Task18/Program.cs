// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат в этой четверти (x и y).


using System.Runtime.Intrinsics.X86;

string GetCoordinatesRange(int num) // Метод
{
    if (num == 1) return "x > 0, y > 0";
    if (num == 2) return "x < 0, y > 0";
    if (num == 3) return "x < 0, y < 0";
    if (num == 4) return "x > 0, y < 0"; // Условия
    return null; // Возврат нуля при невыполнении ни одного условия
}

Console.WriteLine("Введите номер четверти"); // Запрос на ввод координат
int quater = Convert.ToInt32(Console.ReadLine()); // Конвертация


string getCoordinatesRange = GetCoordinatesRange(quater); // Вызов метода
string result = getCoordinatesRange != null ? $"Заданному номеру четверти, соответсвует диапазон: {getCoordinatesRange}" : "Введены некорректные координаты"; // Тернарный оператор, создаем переменную
                                                                            // Если больше нуля ? тогда формируем строку для вывода переменной : иначе возвращаем строку

Console.WriteLine(getCoordinatesRange);