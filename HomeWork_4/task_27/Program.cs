// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Please enter your number: "); // Запрашиваем у пользователя любое число.
int num = Convert.ToInt32(Console.ReadLine()); // Присваиваем введенное значение переменной num и преобразуем его в числовое значение.
int sum = 0;
// Создаем метод для расчета суммы цифр числа.
int Summ(int num)
{
    while (num > 0)
    {
        int dig = num % 10;
        num = num / 10;
        sum = sum + dig;
    }
    Console.WriteLine("The sum of all digits of a number is " + sum);
    return sum;
}
// Вызываем метод для указанного пользователем числа.
Summ(num);
