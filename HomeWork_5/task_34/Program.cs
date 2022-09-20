// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Please enter the length of the array: "); // Запрашиваем длину массива у пользователя
int size = Convert.ToInt32(Console.ReadLine()); //Объявляем переменную size и присваиваем ей значение длинны массива, преобразованное в числовое значение 
int[] numbers = new int[size]; // Создаем массив заданной длинны

void FillArrayRandomNumbers(int[] numbers) // Создаем метод, заполняющий массив случайными числами
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 1000);

    }
    Console.Write("Array created: ");
}
void PrintArray(int[] numbers) // Создаем метод, отображающий содержимое массива
{
    Console.Write("[ ");
    for (int j = 0; j < numbers.Length; j++)
    {
        Console.Write(numbers[j] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

void CountArray(int[] numbers) // Создаем метод для подсчета количества четных чисел в созданном массиве
{
    int count = 0;

    for (int a = 0; a < numbers.Length; a++)
        if (numbers[a] % 2 == 0)
            count++;

    Console.WriteLine($"There are {count} even numbers in the created array.");
}
// Вызываем созданные методы
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
CountArray(numbers);