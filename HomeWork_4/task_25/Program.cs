﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Please enter number A: "); // Запрашиваем у пользователя значение A.
int a = Convert.ToInt32(Console.ReadLine()); // Присваиваем введенное значение переменной a и преобразуем его в числовое значение.
Console.Write("Please enter number B: "); // Запрашиваем у пользователя значение A.
int b = Convert.ToInt32(Console.ReadLine()); // Присваиваем введенное значение переменной b и преобразуем его в числовое значение.

int exp = a; //Обьявляем переменную exp и присваиваем ей значение переменной а;

for (int i = 1; i < b; i++) // Используем цикл for для возведения A в степень B.
{
    exp = exp * a;
}

Console.WriteLine("A raised to the Bth power is " + exp ); //Выводим результат в консоль. 