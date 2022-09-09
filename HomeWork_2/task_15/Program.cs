// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Please, enter the number of the day of the week (from 1 to 7) to check if this day is the weekend: "); //Запрашиваем номер дня недели у пользователя.
int day = Convert.ToInt32(Console.ReadLine()); // Присваиваем введенное значение переменной day и преобразуем его в числовое значение.

void DayCheck(int day) // СОздадим функцию для определения дня недели.
{
    if (day == 6 || day == 7) // Если введенный день равен 6 или 7, то выводим в консоль сообщение, что этот день выходной.
    {
        Console.WriteLine(day + " is the weekend day.");
    }
    else if (day < 1 || day > 7) // Иначе, если введенный день меньше 1 или больше 7, выводим в консоль сообщение, что введен не правильный номер дня.
    {
        Console.WriteLine("There are only 7 days in a week. Please, enter day from 1 to 7.");
    }
    else Console.WriteLine(day + " is a normal working day of the week."); // Иначе, выводим в консоль сообщение введенный день - обычный рабочий день недели.
}

DayCheck(day); // Вызываем функцию.