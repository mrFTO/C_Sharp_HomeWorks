﻿// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B(2, 1, -7), -> 15.84
// A(7, -5, 0); B(1, -1, 9)-> 11.53

//Объявляем переменные координат.
int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

// Создаем метод, который запрашивает значение координат для точек отрезка и возвращает полученный результат.
int Coordinate(string coord, string point)
{
    Console.Write("Please enter the coordinate " + coord + " of the point " + point + ": ");
    return Convert.ToInt16(Console.ReadLine());
}
// Создаем метод, который будет определять длинну отрезка по заданным координатам.
double Decision(double x1, double x2,
                double y1, double y2,
                double z1, double z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) +
                     Math.Pow((y2 - y1), 2) +
                     Math.Pow((z2 - z1), 2));
}
// Используем метод для определения длинны отрезка и присваиваем полученное значение переменной segmentLength.
double segmentLength = Math.Round(Decision(x1, x2, y1, y2, z1, z2), 2);

Console.WriteLine("The length of the segment is " + segmentLength); // Выводим в консоль длинну отрезка.