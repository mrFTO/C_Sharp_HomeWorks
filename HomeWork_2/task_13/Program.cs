// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Please, enter any number: "); //Запрашиваем число у пользователя.
int num = Convert.ToInt32(Console.ReadLine()); // Присваиваем введенное значение переменной num и преобразуем его в числовое значение.
string strNum = Convert.ToString(num); //Обьявляем стороку strNum и присваиваем ей преобразование значения переменной num в строку.
if (strNum.Length > 2)
{
    Console.WriteLine("The third digit of the entered number is " + strNum[2]); //Выводим в консоль третий символ стороки strNum, если длинна стороки больше 2.
}
else
{
    Console.WriteLine("No third digit."); // Иначе, выводим в консоль, что нет третьей цифры.
}