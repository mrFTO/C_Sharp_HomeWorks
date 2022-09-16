// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


int[] numbers = new int[8]; // Создаем массив из 8 элементов и заполняем его случайными числами от 0 до 10.
Console.Write("[");

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(0, 11);
    Console.Write(" " + Method(i) + " ");
}
Console.Write("]");

int Method(int a)
{
    return numbers[a];
}

