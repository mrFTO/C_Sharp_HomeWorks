// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Please enter a five-digit number: "); // Запрашиваем пятизначное число.
string? num = Console.ReadLine(); // Присваем запрошенной значение переменной num в виде строки.

void NumCheck(string num) // Создаем метод, который будет определять, если равны значения первого и последнего или второго и предпоследнего значения введенного числа, то выводит в консоль, что число является палиндромом, иначе, сообщает, что число не является палиндромом.
{
    if (num[0] == num[4] || num[1] == num[3])
    {
        Console.WriteLine("The entered number " + num + " is a palindrome.");
    }
    else Console.WriteLine("The entered number " + num + " is not a palindrome.");
}

if (num!.Length == 5) // Если длинна введенного числа равна 5, запускаем наш метод, иначе, сообщаем, что введено не пятизначное число.
{
    NumCheck(num);
}
else Console.WriteLine("You entered a non-five-digit number.");
