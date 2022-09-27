// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)
// Создаем метод, который будет запрашивать координаты и находить точку пересечения прямых.
void Coords()
{
    Console.Write("Please enter a value for b1: ");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Please enter a value for k1: ");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Please enter a value for b2: ");
    double b2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Please enter a value for k2: ");
    double k2 = Convert.ToInt32(Console.ReadLine());
    // Вычисляем координаты точки пересечения прямых
    double x = (-b2 + b1) / (-k1 + k2);
    double y = k2 * x + b2;

    Console.WriteLine($"Two lines intersect at a point with coordinates x: {x}; y: {y}");
}
Coords(); // Вызываем метод